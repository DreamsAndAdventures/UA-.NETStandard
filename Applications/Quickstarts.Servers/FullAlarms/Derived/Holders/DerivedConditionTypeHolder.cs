using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS1591

namespace FullAlarms
{
    public class DerivedConditionTypeHolder : ConditionTypeHolder
    {
        public DerivedConditionTypeHolder(
            AlarmNodeManager alarms,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true) :
            base(alarms, parent, trigger, name, alarmConditionType, controllerType, interval, optional)
        {
            Initialize(AlarmHelpers.GetDerivedIdentifier(Opc.Ua.ObjectTypes.ConditionType), name);
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name)
        {
            if (m_alarm == null)
            {
                m_alarm = new DerivedConditionType(m_parent);
            }

            base.Initialize(alarmTypeIdentifier, name);

            m_alarm.TypeDefinitionId = new NodeId(alarmTypeIdentifier, m_alarmNodeManager.NamespaceIndex);
            m_alarm.EventType.Value = new NodeId(alarmTypeIdentifier, m_alarmNodeManager.NamespaceIndex);
        }
    }
}
