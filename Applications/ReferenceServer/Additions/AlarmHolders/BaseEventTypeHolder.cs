using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class BaseEventTypeHolder : AlarmHolder
    {
        protected BaseEventTypeHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional) :
            base(alarms, controllerType, interval)
        {
            m_optional = optional;
        }

        protected void Initialize(
            FolderState parent,
            uint alarmTypeIdentifier,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            bool optional = true)
        {
            if (m_alarm != null)
            {
                // Call the base class to set parameters
                base.Initialize(parent, GetAlarmTypeName( alarmTypeIdentifier), name);

                BaseEventState alarm = (BaseEventState)m_alarm;

                alarm.EventId.Value = Guid.NewGuid().ToByteArray();
                alarm.EventType.Value = new NodeId( alarmTypeIdentifier, GetNameSpaceIndex( alarmTypeIdentifier ) );
                alarm.SourceNode.Value = m_trigger.NodeId;
                alarm.SourceName.Value = m_trigger.SymbolicName;
                alarm.Time.Value = DateTime.UtcNow;
                alarm.ReceiveTime.Value = alarm.Time.Value;
                alarm.Message.Value = name + " Initialized";
                alarm.Severity.Value = 0;
            }
        }

        #region Overrides

        public override void SetValue(bool valueUpdated, string message = "")
        {
            
        }

        #endregion

        #region Helpers

        private BaseEventState GetAlarm()
        {
            return (BaseEventState)m_alarm;
        }

        protected string GetAlarmTypeName(UInt32 alarmTypeIdentifier)
        {
            string alarmTypeName = "";

            switch (alarmTypeIdentifier)
            {
                case Opc.Ua.ObjectTypes.ConditionType:
                    alarmTypeName = "ConditionType";
                    break;

                case Opc.Ua.ObjectTypes.DialogConditionType:
                    alarmTypeName = "DialogConditionType";
                    break;

                case Opc.Ua.ObjectTypes.AcknowledgeableConditionType:
                    alarmTypeName = "AcknowledgeableConditionType";
                    break;

                case Opc.Ua.ObjectTypes.AlarmConditionType:
                    alarmTypeName = "AlarmConditionType";
                    break;

                case Opc.Ua.ObjectTypes.AlarmGroupType:
                    alarmTypeName = "AlarmGroupType";
                    break;

                case Opc.Ua.ObjectTypes.ShelvedStateMachineType:
                    alarmTypeName = "ShelvedStateMachineType";
                    break;

                case Opc.Ua.ObjectTypes.LimitAlarmType:
                    alarmTypeName = "LimitAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveLimitStateMachineType:
                    alarmTypeName = "ExclusiveLimitStateMachineType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveLimitAlarmType:
                    alarmTypeName = "ExclusiveLimitAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveLimitAlarmType:
                    alarmTypeName = "NonExclusiveLimitAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveLevelAlarmType:
                    alarmTypeName = "NonExclusiveLevelAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveLevelAlarmType:
                    alarmTypeName = "ExclusiveLevelAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveDeviationAlarmType:
                    alarmTypeName = "NonExclusiveDeviationAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveRateOfChangeAlarmType:
                    alarmTypeName = "NonExclusiveRateOfChangeAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveDeviationAlarmType:
                    alarmTypeName = "ExclusiveDeviationAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveRateOfChangeAlarmType:
                    alarmTypeName = "ExclusiveRateOfChangeAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.DiscreteAlarmType:
                    alarmTypeName = "DiscreteAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.OffNormalAlarmType:
                    alarmTypeName = "OffNormalAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.SystemOffNormalAlarmType:
                    alarmTypeName = "SystemOffNormalAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.TripAlarmType:
                    alarmTypeName = "TripAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.InstrumentDiagnosticAlarmType:
                    alarmTypeName = "InstrumentDiagnosticAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.SystemDiagnosticAlarmType:
                    alarmTypeName = "SystemDiagnosticAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.CertificateExpirationAlarmType:
                    alarmTypeName = "CertificateExpirationAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.DiscrepancyAlarmType:
                    alarmTypeName = "DiscrepancyAlarmType";
                    break;
            }

            return alarmTypeName;
        }

        protected ushort GetNameSpaceIndex( UInt32 alarmTypeIdentifier )
        {
            ushort nameSpaceIndex = 0;
               
            switch ( alarmTypeIdentifier )
            {
                case Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE:
                    nameSpaceIndex = m_alarms.GetNodeManager().NamespaceIndex;
                    break;
            }

            return nameSpaceIndex;
        }

        #endregion

        #region Child Helpers

        protected bool IsEvent( byte[] eventId )
        {
            return GetAlarm().EventId.Value.SequenceEqual(eventId);
        }

        #endregion

    }
}
