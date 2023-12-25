





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public interface ITrigger
    {
        bool isReady { get; }
		void SetParam(object[] param);
        void Start(Action<bool, ITrigger> l);
        void Stop();
    }
}
