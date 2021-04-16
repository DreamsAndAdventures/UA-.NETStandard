using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class DiscrepancyAlarmTypeHolder : AlarmConditionTypeHolder
    {
        public DiscrepancyAlarmTypeHolder(
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
                Initialize(Opc.Ua.ObjectTypes.DiscrepancyAlarmType, name, maxShelveTime);
            }
        }

        public void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            m_analog = false;

            if (m_alarm == null)
            {
                m_alarm = new DiscrepancyAlarmState(m_parent);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);
        }

        #region Overrides

        //public override void SetValue(bool valueUpdated, string message = "")
        //{

        //    if (valueUpdated)
        //    {
        //        DiscreteAlarmState alarm = GetAlarm();
        //        bool active = m_alarmController.IsBooleanActive();
        //        int value = m_alarmController.GetValue();
        //        if (this.GetType().Name == "DiscreteHolder")
        //        {
        //            if (value > 50)
        //            {
        //                bool waiting = true;

        //            }
        //            else
        //            {
        //                bool waiting = true;

        //            }


        //        }
        //        base.SetValue(true, message);
        //    }
        //}

        #endregion


        #region Helpers
        private DiscrepancyAlarmState GetAlarm()
        {
            return (DiscrepancyAlarmState)m_alarm;
        }

        #endregion



    }
}
