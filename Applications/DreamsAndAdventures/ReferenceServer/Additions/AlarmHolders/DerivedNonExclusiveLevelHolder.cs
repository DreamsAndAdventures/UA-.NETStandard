using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class DerivedNonExclusiveLevelHolder : NonExclusiveLevelHolder
    {
        public DerivedNonExclusiveLevelHolder(
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
                Initialize(Helpers.GetDerivedIdentifier(Opc.Ua.ObjectTypes.NonExclusiveLevelAlarmType), name, maxShelveTime);
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
                m_alarm = new DerivedNonExclusiveLevelAlarmType(m_parent);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved, isLimit: false);
        }
    }
}