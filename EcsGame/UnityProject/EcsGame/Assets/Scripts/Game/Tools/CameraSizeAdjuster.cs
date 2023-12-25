using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public class CameraSizeAdjuster : MonoBehaviour
    {
        public enum MatchMode
        {
            Width,
            Height,
        }

        [SerializeField]
        private Vector2 m_ReferenceResolution;
        [SerializeField]
        private MatchMode m_MatchMode = MatchMode.Height;
        [SerializeField]
        private Camera m_Camera;

        private void Awake()
        {
            Adjust();
        }
        
        private void Adjust()
        {
            if (m_MatchMode == MatchMode.Width)
            {
                float cameraWidthSize = m_Camera.orthographicSize * m_ReferenceResolution.x / m_ReferenceResolution.y;
                float needCameraSize = (float)Screen.height / (float)Screen.width * cameraWidthSize;
                m_Camera.orthographicSize = needCameraSize;
            }
        }
    }
}
