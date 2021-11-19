using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS0219


namespace DreamsAndAdventures.ReferenceServer
{
    class DiscrepancyAlarmTypeHolder : AlarmConditionTypeHolder
    {
        public DiscrepancyAlarmTypeHolder(
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
                Initialize(Opc.Ua.ObjectTypes.DiscrepancyAlarmType, name, maxShelveTime);
            }
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {

            if (m_alarm == null)
            {
                m_alarm = new DiscrepancyAlarmState(m_parent);
            }

            DiscrepancyAlarmState alarm = GetAlarm();

            if (alarm.TargetValueNode == null)
            {
                // This should not be hit, it's mandatory!
                bool alwaysBreak = true; 
                alarm.TargetValueNode = new PropertyState<NodeId>(alarm);
            }

            if ( Optional )
            {
                if ( alarm.Tolerance == null )
                {
                    alarm.Tolerance = new PropertyState<double>(alarm);
                }
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);

            alarm.TargetValueNode.Value = GetTargetValueNodeId();

            alarm.ExpectedTime.Value = 100;

            if (Optional)
            {
                alarm.Tolerance.Value = 5;
            }
        }

        #region Overrides

        public override void SetValue(string message = "")
        {
            BaseDataVariableState target = (BaseDataVariableState)GetTargetValueNodeState();
            int value = m_alarmController.GetValue();

            int newValue = value;
            if (IsActive())
            {
                newValue = value + 100;
            }
            target.Value = newValue;
            target.Timestamp = DateTime.UtcNow;
            target.ClearChangeMasks(SystemContext, false);

            base.SetValue(message);
        }

        #endregion


        #region Helpers
        private DiscrepancyAlarmState GetAlarm()
        {
            return (DiscrepancyAlarmState)m_alarm;
        }

        private NodeId GetTargetValueNodeId()
        {
            string[] splits = m_mapName.Split('.');
            return new NodeId(splits[0] + "." + splits[1] + "." + Defines.DISCREPANCY_TARGET_NAME, NamespaceIndex);
        }

        private NodeState GetTargetValueNodeState()
        {
            return GetNodeManager().FindPredefinedNode(GetTargetValueNodeId(), null);
        }

        #endregion



    }
}
