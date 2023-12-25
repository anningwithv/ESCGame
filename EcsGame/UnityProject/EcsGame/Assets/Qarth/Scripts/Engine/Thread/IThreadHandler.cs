





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public interface IThreadHandler
    {
        void PostTask(IThreadTask task);
        void PostAction(Action action);
    }
}
