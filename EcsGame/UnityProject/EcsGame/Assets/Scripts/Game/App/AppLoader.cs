using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;

namespace Game.Logic
{
    public class AppLoader : MonoBehaviour
    {
        private void Awake()
        {
            //Log.i("Init[{0}]", ApplicationMgr.S.GetType().Name); 
            ApplicationMgr.S.GetType();
        }

        private void Start()
        {
            Destroy(gameObject);
        }

        
    }
}
