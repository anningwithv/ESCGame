





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public class AbstractTask : IThreadTask
    {
        public virtual bool Execute()
        {
            return true;
        }

        public virtual void ProcessResult()
        {
        }
    }
}
