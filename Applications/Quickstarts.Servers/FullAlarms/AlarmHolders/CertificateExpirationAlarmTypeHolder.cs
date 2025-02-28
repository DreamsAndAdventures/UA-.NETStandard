
using System;

using Opc.Ua;

#pragma warning disable CS1591

namespace FullAlarms
{
    public class CertificateExpirationAlarmTypeHolder : SystemOffNormalAlarmTypeHolder
    {
        public CertificateExpirationAlarmTypeHolder(
            FullAlarmNodeManager alarmNodeManager,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = AlarmDefines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarmNodeManager, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.CertificateExpirationAlarmType, name, maxShelveTime);
            }
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = AlarmDefines.NORMAL_MAX_TIME_SHELVED)
        {
            if (m_alarm == null)
            {
                m_alarm = new CertificateExpirationAlarmState(m_parent);
            }

            CertificateExpirationAlarmState alarm = GetAlarm();

            alarm.Certificate = new PropertyState<byte[]>(alarm);
            alarm.CertificateType = new PropertyState<NodeId>(alarm);


            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);

            alarm.NormalState.Value = new NodeId();

            DateTime expire = DateTime.UtcNow;
            alarm.ExpirationDate.Value = expire.AddMonths(12);

            // One day
            alarm.ExpirationLimit.Value = Convert.ToDouble(1000 * 60 * 60 * 24);
            alarm.Certificate.Value = new byte[0];
            alarm.CertificateType.Value = ObjectTypeIds.RsaSha256ApplicationCertificateType;
        }

        #region Helpers

        private CertificateExpirationAlarmState GetAlarm()
        {
            return (CertificateExpirationAlarmState)m_alarm;
        }

        #endregion

    }
}
