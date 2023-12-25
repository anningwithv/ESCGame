





using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFrame
{
    public interface ITransitionHandler
    {
        AbstractPanel transitionPanel
        {
            get;
        }
        void OnTransitionPrepareFinish();
        void OnTransitionInFinish();
        void OnTransitionOutFinish();
    }

}
