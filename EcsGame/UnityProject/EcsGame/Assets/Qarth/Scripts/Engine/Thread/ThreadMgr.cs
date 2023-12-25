





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public class ThreadMgr : TSingleton<ThreadMgr>
    {
        private ThreadHandler m_WorkThread;
        private MainThreadHandler m_MainThread;

        public override void OnSingletonInit()
        {
            m_MainThread = MainThreadHandler.S;
            m_WorkThread = new ThreadHandler("WorkThread");
        }

        public void Init()
        {

        }

        public IThreadHandler workThread
        {
            get { return m_WorkThread; }
        }

        public IThreadHandler mainThread
        {
            get { return m_MainThread; }
        }

    }
}
