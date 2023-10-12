using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace FullAlarms
{
    class DerivedExclusiveLevelHolder : ExclusiveLevelHolder
    {
        public DerivedExclusiveLevelHolder(
            AlarmNodeManager alarms,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = AlarmDefines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(AlarmHelpers.GetDerivedIdentifier(Opc.Ua.ObjectTypes.ExclusiveLevelAlarmType), name, maxShelveTime);
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
                m_alarm = new DerivedExclusiveLevelAlarmType(m_parent);
            }

            m_alarm.TypeDefinitionId = new NodeId(alarmTypeIdentifier, m_alarmNodeManager.NamespaceIndex);

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved, isLimit: false);
            Debug.WriteLine("DerivedExclusiveLevelHolder alarm typedefinition " + m_alarm.TypeDefinitionId.ToString());
            m_alarm.EventType.Value = new NodeId(alarmTypeIdentifier, m_alarmNodeManager.NamespaceIndex);
        }
    }
}
