using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class ExclusiveRateOfChangeHolder : ExclusiveLimitHolder
    {
        public ExclusiveRateOfChangeHolder(
            Alarms alarms,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.ExclusiveRateOfChangeAlarmType, name, optional, maxShelveTime);
            }
        }

        public void Initialize(
            uint alarmTypeIdentifier,
            string name,
            bool optional = true,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new ExclusiveRateOfChangeAlarmState(m_parent);
            }

            ExclusiveRateOfChangeAlarmState alarm = (ExclusiveRateOfChangeAlarmState)m_alarm;

            if( Optional )
            {
                alarm.EngineeringUnits = new PropertyState<EUInformation>(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved, isLimit: false);

            alarm.HighLimit.Value = Defines.RATEOFCHANGE_HIGH_ALARM;

            if (Optional)
            {
                alarm.EngineeringUnits.Value = new EUInformation("rad/s", "radian per second", "http://www.opcfoundation.org/UA/units/un/cefact");
                alarm.EngineeringUnits.Value.UnitId = 12865; // "2A"	

                alarm.HighHighLimit.Value = Defines.RATEOFCHANGE_HIGHHIGH_ALARM;
                alarm.LowLimit.Value = Defines.RATEOFCHANGE_LOW_ALARM;
                alarm.LowLowLimit.Value = Defines.RATEOFCHANGE_LOWLOW_ALARM;

                alarm.BaseHighLimit.Value = Defines.RATEOFCHANGE_HIGH_ALARM;
                alarm.BaseHighHighLimit.Value = Defines.RATEOFCHANGE_HIGHHIGH_ALARM;
                alarm.BaseLowLimit.Value = Defines.RATEOFCHANGE_LOW_ALARM;
                alarm.BaseLowLowLimit.Value = Defines.RATEOFCHANGE_LOWLOW_ALARM;
            }
            else
            {
                if (alarm.HighHighLimit != null)
                {
                    alarm.HighHighLimit = null;
                }
                if (alarm.LowLimit != null)
                {
                    alarm.LowLimit = null;
                }
                if (alarm.LowLowLimit != null)
                {
                    alarm.LowLowLimit = null;
                }

                if (alarm.EngineeringUnits != null)
                {
                    alarm.EngineeringUnits = null;
                }
            }

            RateOfChangeController controller = (RateOfChangeController)m_alarmController;
            controller.WriteCurrentValue(SystemContext);
        }

        public override void SetValue(string message = "")
        {
            string localMessage = message;
            if (localMessage.Length <= 0 && ShouldEvent())
            {
                RateOfChangeController controller = (RateOfChangeController)m_alarmController;
                localMessage = "Alarm Event Value = " + controller.GetValue().ToString() +
                    " Previous Value " + controller.PreviousValue.ToString() +
                    " Rate Of Change per second " + controller.RateOfChange.ToString();
            }

            base.SetValue(localMessage);
        }


        protected override ushort GetSeverity()
        {
            ushort severity = Defines.INACTIVE_SEVERITY;

            RateOfChangeController controller = (RateOfChangeController)m_alarmController;

            int rateOfChange = controller.RateOfChange;

            if (Optional)
            {
                if (rateOfChange >= Defines.RATEOFCHANGE_HIGHHIGH_ALARM )
                {
                    severity = Defines.HIGHHIGH_SEVERITY;
                }
                else if (rateOfChange >= Defines.RATEOFCHANGE_HIGH_ALARM)
                {
                    severity = Defines.HIGH_SEVERITY;
                }
                else if (rateOfChange <= Defines.RATEOFCHANGE_LOWLOW_ALARM)
                { 
                    severity = Defines.LOWLOW_SEVERITY;
                }
                else if (rateOfChange <= Defines.RATEOFCHANGE_LOW_ALARM)
                {
                    severity = Defines.LOW_SEVERITY;
                }
            }
            else
            {
                if (rateOfChange >= Defines.RATEOFCHANGE_HIGH_ALARM)
                {
                    severity = Defines.HIGH_SEVERITY;
                }
            }

            Log("ExclusiveRateOfChangeHolder::GetSeverity",
                "Rate Of Change " + rateOfChange.ToString() +
                " Value " + controller.GetValue().ToString() + " Previous " + controller.PreviousValue.ToString() +
                " span in seconds " + controller.SpanTime.ToString() + 
                " Severity " + severity.ToString());

            return severity;
        }

    }
}
