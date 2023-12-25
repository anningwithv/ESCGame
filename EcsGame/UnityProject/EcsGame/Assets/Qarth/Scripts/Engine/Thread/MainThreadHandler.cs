





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    [TMonoSingletonAttribute("[App]/AppLoopMgr")]
    public class MainThreadHandler : TMonoSingleton<MainThreadHandler>, IThreadHandler
    {
        protected TaskLoop m_TaskLoop = new TaskLoop();

        public void PostTask(IThreadTask task)
        {
            m_TaskLoop.PostTask(task);
        }

        public void PostAction(Action action)
        {
            m_TaskLoop.PostAction(action);
        }

        public void Dump()
        {

        }

        private void Update()
        {
            m_TaskLoop.OnceLoop();
        }
    }
}
