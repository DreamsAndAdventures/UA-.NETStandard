using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class OffNormalAlarmTypeHolder : DiscreteHolder
    {
        public OffNormalAlarmTypeHolder(
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
                Initialize(parent, Opc.Ua.ObjectTypes.OffNormalAlarmType, name, alarmConditionType, optional, maxShelveTime);
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
            if (m_alarm == null)
            {
                m_alarm = new OffNormalAlarmState(parent);
            }

            OffNormalAlarmState alarm = GetAlarm();

            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional, maxTimeShelved);

            alarm.NormalState.Value = new NodeId();
        }

        #region Helpers

        private OffNormalAlarmState GetAlarm()
        {
            return (OffNormalAlarmState)m_alarm;
        }

        #endregion

    }
}
