using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class DerivedSystemOffNormalAlarmTypeHolder : SystemOffNormalAlarmTypeHolder
    {
        public DerivedSystemOffNormalAlarmTypeHolder(
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
                Initialize(Helpers.GetDerivedIdentifier(Opc.Ua.ObjectTypes.SystemOffNormalAlarmType), name, maxShelveTime);
            }
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            if (m_alarm == null)
            {
                m_alarm = new DerivedSystemOffNormalAlarmType(m_parent);
            }

            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);
        }
    }
}
