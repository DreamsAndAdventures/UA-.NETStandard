using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
namespace Quickstarts.ReferenceServer
{
    class NonExclusiveRateOfChangeHolder : NonExclusiveLevelHolder
    {
        public NonExclusiveRateOfChangeHolder(
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
                Initialize(parent, Opc.Ua.ObjectTypes.NonExclusiveRateOfChangeAlarmType, name, alarmConditionType, optional, maxShelveTime);
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
                m_alarm = new NonExclusiveRateOfChangeAlarmState(parent);
            }

            NonExclusiveRateOfChangeAlarmState alarm = (NonExclusiveRateOfChangeAlarmState)m_alarm;

            if (Optional)
            {
                alarm.EngineeringUnits = new PropertyState<EUInformation>(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional, maxTimeShelved);

            if (Optional)
            {
                alarm.EngineeringUnits.Value = new EUInformation();
            }
        }
    }
}