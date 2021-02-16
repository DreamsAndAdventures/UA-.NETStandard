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
                Initialize(Opc.Ua.ObjectTypes.ExclusiveRateOfChangeAlarmType, name, maxShelveTime);
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

            if (Optional)
            {
                alarm.EngineeringUnits.Value = new EUInformation("ExclusiveTestUnits", "UriHolder");
            }
        }
    }
}
