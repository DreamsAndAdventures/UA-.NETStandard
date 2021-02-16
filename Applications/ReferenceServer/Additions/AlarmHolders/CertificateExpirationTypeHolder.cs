using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class CertificateExpirationTypeHolder : SystemOffNormalAlarmTypeHolder
    {
        public string m_name = "";

        public CertificateExpirationTypeHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            m_name = name;

            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.CertificateExpirationAlarmType, name, maxShelveTime);
            }
        }

        public void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            if (m_alarm == null)
            {
                m_alarm = new CertificateExpirationAlarmState(m_parent);
            }

            CertificateExpirationAlarmState alarm = GetAlarm();

            // Not Set up for non optional
            alarm.ExpirationLimit = new PropertyState<double>(alarm);

            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);

            alarm.ExpirationLimit.Value = Defines.MILLISECONDS_PER_WEEK;
            alarm.Certificate.Value = new byte[1];
            alarm.CertificateType.Value = new NodeId(Opc.Ua.ObjectTypes.ApplicationCertificateType);

            Reset( trigger: false );
        }

        public override void SetValue(bool valueUpdated, string message = "")
        {
            CertificateExpirationAlarmState alarm = GetAlarm();

            bool triggerActive = m_alarmController.IsBooleanActive();
            bool alarmActive = alarm.ActiveState.Id.Value;

            if (!alarmActive && triggerActive)
            {
                // Need to check for expiration
                double limit = alarm.ExpirationLimit.Value;
                DateTime expires = alarm.ExpirationDate.Value;
                expires = expires.AddMilliseconds(-limit);
                if (expires.CompareTo(DateTime.UtcNow) < 0)
                {
                    base.SetValue(valueUpdated, GetAlarmMessage());
                }
            }
        }

        #region Helpers

            private CertificateExpirationAlarmState GetAlarm()
        {
            return (CertificateExpirationAlarmState)m_alarm;
        }

        public string GetAlarmMessage()
        {
            string message = "Certificate set to expire at " + GetAlarm().ExpirationDate.Value.ToString();
            if (m_name == Defines.EXPIRED_LIMIT_NAME)
            {
                message = "Certificate Expired";
            }
            return message;
        }


        #endregion

        #region Methods

        public void Set( )
        {
            int milliseconds = 0;
            if ( m_name == Defines.OUTSIDE_LIMIT_NAME )
            {
                milliseconds = Defines.MILLISECONDS_PER_WEEK + Defines.MILLISECONDS_PER_SECOND * 40;
            }
            else if ( m_name == Defines.INSIDE_LIMIT_NAME )
            {
                milliseconds = Defines.MILLISECONDS_PER_WEEK - Defines.MILLISECONDS_PER_SECOND;
            }
            else if ( m_name == Defines.EXPIRED_LIMIT_NAME )
            {
                milliseconds = -Defines.MILLISECONDS_PER_WEEK;
            }
            DateTime expirationDate = DateTime.UtcNow;
            expirationDate = expirationDate.AddMilliseconds(milliseconds);

            CertificateExpirationAlarmState alarm = GetAlarm();

            GetAlarm().ExpirationDate.Value = expirationDate;

            alarm.ClearChangeMasks(SystemContext, true);
        }

        public void Reset( bool trigger = true )
        {
            DateTime checkDate = DateTime.UtcNow;
            DateTime expirationDate = DateTime.UtcNow;
            expirationDate = expirationDate.AddMonths( 7 );

            CertificateExpirationAlarmState alarm = GetAlarm();
            alarm.ExpirationDate.Value = expirationDate;

            if (trigger)
            {
                bool triggerActive = m_alarmController.IsBooleanActive();
                if (triggerActive)
                {
                    // Toggle the value back down
                    Update();
                }

                if (alarm.ActiveState.Id.Value)
                {
                    base.SetValue(true, "Certificate Expiration has been reset");
                }
                else
                {
                    alarm.ClearChangeMasks(SystemContext, true);
                }
            }
        }

        #endregion
    }
}
