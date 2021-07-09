using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class NonExclusiveDeviationHolder : NonExclusiveLevelHolder
    {
        public NonExclusiveDeviationHolder(
            Alarms alarms,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            BaseDataVariableState setpoint,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.NonExclusiveDeviationAlarmType, name, setpoint, maxShelveTime);
            }
        }

        public void Initialize(
            uint alarmTypeIdentifier,
            string name,
            BaseDataVariableState setpoint,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new NonExclusiveDeviationAlarmState(m_parent);
            }

            NonExclusiveDeviationAlarmState alarm = (NonExclusiveDeviationAlarmState)m_alarm;

            if (Optional)
            {
                alarm.BaseSetpointNode = new PropertyState<NodeId>(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved, isLimit: false);

            alarm.SetpointNode.Value = new NodeId( setpoint.NodeId );
            DeviationController controller = (DeviationController)m_alarmController;

            controller.Setpoint = setpoint;

            alarm.HighLimit.Value = Defines.DEVIATION_HIGH_ALARM;

            if (Optional)
            {
                alarm.HighHighLimit.Value = Defines.DEVIATION_HIGHHIGH_ALARM;
                alarm.LowLimit.Value = Defines.DEVIATION_LOW_ALARM;
                alarm.LowLowLimit.Value = Defines.DEVIATION_LOWLOW_ALARM;

                alarm.BaseHighLimit.Value = Defines.DEVIATION_HIGH_ALARM;
                alarm.BaseHighHighLimit.Value = Defines.DEVIATION_HIGHHIGH_ALARM;
                alarm.BaseLowLimit.Value = Defines.DEVIATION_LOW_ALARM;
                alarm.BaseLowLowLimit.Value = Defines.DEVIATION_LOWLOW_ALARM;
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

                alarm.BaseSetpointNode.Value = new NodeId(setpoint.NodeId);
            }
        }

        public override void SetValue(string message = "")
        {
            string localMessage = message;
            if (localMessage.Length <= 0 && ShouldEvent())
            {
                DeviationController controller = (DeviationController)m_alarmController;
                localMessage = "Alarm Event Value = " + controller.DeviationActualValue.ToString() +
                    " Setpoint " + controller.DeviationSetpointValue.ToString() +
                    " Deviation " + controller.Deviation.ToString();
            }

            base.SetValue(localMessage);
        }


        protected override ushort GetSeverity()
        {
            ushort severity = Defines.INACTIVE_SEVERITY;

            DeviationController controller = (DeviationController)m_alarmController;

            if (Optional)
            {
                if (controller.Deviation >= Defines.DEVIATION_HIGHHIGH_ALARM)
                {
                    severity = Defines.HIGHHIGH_SEVERITY;
                }
                else if (controller.Deviation >= Defines.DEVIATION_HIGH_ALARM)
                {
                    severity = Defines.HIGH_SEVERITY;
                }
                else if (controller.Deviation <= Defines.DEVIATION_LOWLOW_ALARM)
                {
                    severity = Defines.LOWLOW_SEVERITY;
                }
                else if (controller.Deviation >= Defines.DEVIATION_LOW_ALARM)
                {
                    severity = Defines.LOW_SEVERITY;
                }
            }
            else
            {
                if (controller.Deviation >= Defines.DEVIATION_HIGH_ALARM)
                {
                    severity = Defines.HIGH_SEVERITY;
                }
            }

            return severity;
        }


    }
}
