using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
namespace Quickstarts.ReferenceServer
{
    class ExclusiveDeviationHolder : ExclusiveLimitHolder
    {
        public ExclusiveDeviationHolder(
            Alarms alarms,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            NodeId setpointNodeId,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.ExclusiveDeviationAlarmType, name, setpointNodeId, maxShelveTime);
            }
        }

        public void Initialize(
            uint alarmTypeIdentifier,
            string name,
            NodeId setpointNodeId,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new ExclusiveDeviationAlarmState(m_parent);
            }

            ExclusiveDeviationAlarmState alarm = (ExclusiveDeviationAlarmState)m_alarm;

            if (Optional)
            {
                alarm.BaseSetpointNode = new PropertyState<NodeId>(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved, isLimit: false);

            alarm.SetpointNode.Value = new NodeId(setpointNodeId);

            if (Optional)
            {
                alarm.BaseSetpointNode.Value = new NodeId(setpointNodeId);
            }
        }
    }
}