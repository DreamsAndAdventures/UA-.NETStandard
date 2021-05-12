using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class ConfirmTestAlarmController : AlarmController
    {
        private bool m_pause = false;

        public ConfirmTestAlarmController(BaseDataVariableState variable, int interval, bool isBoolean) :
            base(variable, interval, isBoolean)
        {
        }

        public override void Stop()
        {
            base.Stop();

            m_pause = false;
        }

        public override bool CanSetValue()
        {
            bool canSetValue = false;

            if ( base.CanSetValue() )
            {
                canSetValue = !m_pause;
            }

            return canSetValue;
        }


        public override void OnAddComment()
        {
            m_pause = true;
        }

        public override void OnAcknowledge()
        {
            m_pause = true;
        }

        public override void OnConfirm()
        {
            m_pause = false;

            m_nextTime = DateTime.Now;
            m_nextTime = m_nextTime.AddMilliseconds(m_interval* 2);
        }
    }
}
