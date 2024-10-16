/* ========================================================================
 * Copyright (c) 2005-2022 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using Opc.Ua;

namespace FullAlarms
{
    class NonExclusiveLimitHolder : LimitAlarmTypeHolder
    {
        public NonExclusiveLimitHolder(
            AlarmNodeManager alarmNodeManager,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = AlarmDefines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarmNodeManager, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.NonExclusiveLimitAlarmType, name, maxShelveTime);
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
                m_alarm = new NonExclusiveLimitAlarmState(m_parent);
            }

            NonExclusiveLimitAlarmState alarm = GetAlarm();

            alarm.HighState = new TwoStateVariableState(alarm);

            if (Optional)
            {
                alarm.HighHighState = new TwoStateVariableState(alarm);
                alarm.LowState = new TwoStateVariableState(alarm);
                alarm.LowLowState = new TwoStateVariableState(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);

            if (!Optional)
            {
                alarm.HighHighState = null;
                alarm.LowState = null;
                alarm.LowLowState = null;
            }
            alarm.SetLimitState(SystemContext, LimitAlarmStates.Inactive);
        }

        protected override ushort GetSeverity()
        {
            ushort severity = AlarmDefines.INACTIVE_SEVERITY;

            if (Optional)
            {
                severity = base.GetSeverity();
            }
            else
            {
                int level = m_alarmController.GetValue();

                if (level >= AlarmDefines.HIGH_ALARM && Analog)
                {
                    severity = AlarmDefines.HIGH_SEVERITY;
                }
            }

            return severity;
        }

        public override void SetValue(string message = "")
        {
            NonExclusiveLimitAlarmState alarm = GetAlarm();
            int newSeverity = GetSeverity();
            int currentSeverity = alarm.Severity.Value;

            if (newSeverity != currentSeverity)
            {
                LimitAlarmStates state = LimitAlarmStates.Inactive;

                if (Optional)
                {
                    if (newSeverity == AlarmDefines.HIGHHIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.HighHigh;
                    }
                    else if (newSeverity == AlarmDefines.HIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.High;
                    }
                    else if (newSeverity == AlarmDefines.LOW_SEVERITY)
                    {
                        state = LimitAlarmStates.Low;
                    }
                    else if (newSeverity == AlarmDefines.LOWLOW_SEVERITY)
                    {
                        state = LimitAlarmStates.LowLow;
                    }
                }
                else
                {
                    if (newSeverity == AlarmDefines.HIGH_SEVERITY || newSeverity == AlarmDefines.HIGHHIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.High;
                    }
                }

                alarm.SetLimitState(SystemContext, state);
            }

            base.SetValue(message);
        }

        private NonExclusiveLimitAlarmState GetAlarm()
        {
            return (NonExclusiveLimitAlarmState)m_alarm;
        }
    }
}
