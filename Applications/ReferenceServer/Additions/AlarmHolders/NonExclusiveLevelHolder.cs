using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class NonExclusiveLevelHolder : NonExclusiveLimitHolder
    {
        public NonExclusiveLevelHolder(
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
            if (create)
            {
                Initialize(parent, Opc.Ua.ObjectTypes.NonExclusiveLevelAlarmType, name, alarmConditionType, optional, maxShelveTime);
            }
        }

        public void Initialize(
            FolderState parent,
            uint alarmTypeIdentifier,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            bool optional = true,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new NonExclusiveLevelAlarmState(parent);
            }

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional, maxTimeShelved, isLimit: false);
        }
    }
}
