





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace GameFrame
{
    public class CaptureHelperTester : MonoBehaviour
    {
        [SerializeField]
        protected RawImage m_Image;

        protected Texture2D m_Tex;

        private void Awake()
        {
            StartCoroutine(CaptureHelper.Capture(UIMgr.S.uiRoot.uiCamera, false, OnCaptureFinish));
        }

        private void OnCaptureFinish(Texture2D tex, string path)
        {
            m_Image.texture = tex;
        }

        private void OnDestroy()
        {
            if (m_Tex != null)
            {
                GameObject.Destroy(m_Tex);
            }
        }
    }
}
