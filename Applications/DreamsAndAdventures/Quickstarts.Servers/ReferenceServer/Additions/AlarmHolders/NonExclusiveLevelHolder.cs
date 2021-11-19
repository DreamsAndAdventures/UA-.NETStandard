using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace DreamsAndAdventures.ReferenceServer
{
    class NonExclusiveLevelHolder : NonExclusiveLimitHolder
    {
        public NonExclusiveLevelHolder(
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
                Initialize(Opc.Ua.ObjectTypes.NonExclusiveLevelAlarmType, name, maxShelveTime);
            }
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new NonExclusiveLevelAlarmState(m_parent);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);
            Debug.WriteLine("NonExclusiveLevelHolder alarm typedefinition " + m_alarm.TypeDefinitionId.ToString());

            //NonExclusiveLevelAlarmState alarm = GetAlarm();

            //if (!Optional)
            //{
            //    alarm.HighHighState = null;
            //    alarm.LowState = null;
            //    alarm.LowLowState = null;
            //}


        }
        public override void SetValue(string message = "")
        {
            base.SetValue(message);

        }

        private NonExclusiveLevelAlarmState GetAlarm()
        {
            return (NonExclusiveLevelAlarmState)m_alarm;
        }


    }
}
