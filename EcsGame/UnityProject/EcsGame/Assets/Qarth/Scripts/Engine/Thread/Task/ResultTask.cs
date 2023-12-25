





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public class ResultTask : AbstractTask
    {
        protected IThreadTask m_Task;

        public ResultTask(IThreadTask task)
        {
            m_Task = task;
        }

        public override bool Execute()
        {
            if (m_Task != null)
            {
                m_Task.ProcessResult();
            }
            return true;
        }
    }
}
