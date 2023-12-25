





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public interface IThreadTask
    {
        //return true if Finish.
        bool Execute();

        void ProcessResult();
    }
}
