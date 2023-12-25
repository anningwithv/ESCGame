





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public class CalculateResultTask : AbstractTask
    {
        protected IThreadHandler m_SourceThread;

        public CalculateResultTask(IThreadHandler sourceThread)
        {
            m_SourceThread = sourceThread;
        }

        protected void SendResult()
        {
            if (m_SourceThread == null)
            {
                return;
            }

            m_SourceThread.PostTask(new ResultTask(this));
        }

        public override void ProcessResult()
        {

        }
    }
}
