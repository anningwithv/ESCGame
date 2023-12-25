





using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public interface IResLoader
    {
        bool Add2Load(string name, Action<bool, IRes> listener, bool lastOrder = true);
        void ReleaseAllRes();
        void UnloadImage(bool flag);
    }
}
