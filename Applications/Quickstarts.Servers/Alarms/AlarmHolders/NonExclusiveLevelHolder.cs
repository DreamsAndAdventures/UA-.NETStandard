using System;

using Opc.Ua;

namespace Alarms
{
    class NonExclusiveLevelHolder : NonExclusiveLimitHolder
    {
        public NonExclusiveLevelHolder(
            AlarmNodeManager alarmNodeManager,
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
                Initialize(Opc.Ua.ObjectTypes.NonExclusiveLevelAlarmType, name, maxShelveTime);
            }
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = AlarmDefines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new NonExclusiveLevelAlarmState(m_parent);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);
            Utils.LogInfo(Utils.TraceMasks.Information, "NonExclusiveLevelHolder alarm typedefinition " + m_alarm.TypeDefinitionId.ToString());



        }
        public override void SetBranching(bool value)
        {
            m_supportsBranching = value;
        }


        private NonExclusiveLevelAlarmState GetAlarm()
        {
            return (NonExclusiveLevelAlarmState)m_alarm;
        }


    }
}
