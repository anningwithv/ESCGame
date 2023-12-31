﻿





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace GameFrame
{
    public class WorldUI : MonoBehaviour
    {
        [SerializeField]
        protected Transform m_TargetUI;
        [SerializeField]
        protected Vector3 m_WorldOffset;
        [SerializeField]
        protected Vector3 m_UIOffset;

        private Vector3 m_ViewPos;

        protected bool m_IsDirty = false;
        protected WorldUIBinding m_Binding = null;

        public float zPos
        {
            get { return m_ViewPos.z; }
        }

        public Vector3 worldOffset
        {
            get { return m_WorldOffset; }
            set
            {
                m_WorldOffset = value;
                UpdateBinding();
            }
        }

        public Vector3 uiOffset
        {
            get { return m_UIOffset; }
            set
            {
                m_UIOffset = value;
                UpdateBinding();
            }
        }

        public Transform targetUI
        {
            get { return m_TargetUI; }
            set
            {
                m_TargetUI = value;
                UpdateBinding();
            }
        }

        public void SetDirty()
        {
            m_IsDirty = true;
            if (m_Binding != null)
            {
                m_Binding.SetDirty();
            }
        }

        protected void UpdateBinding()
        {
            if (m_TargetUI == null)
            {
                return;
            }
            m_IsDirty = true;
            OnWorldUIBinding();
        }

        protected virtual void OnWorldUIBinding()
        {

        }

        protected virtual bool IsNeedUpdate()
        {
            return false;
        }

        protected bool IsWorldPositionInView(Vector3 pos)
        {
            m_ViewPos = Camera.main.WorldToViewportPoint(pos);

            if (m_ViewPos.x < -0.2f || m_ViewPos.x > 1.2f || m_ViewPos.y < -0.2f || m_ViewPos.y > 1.2f)
            {
                return false;
            }
            return true;
        }

        private void OnValidate()
        {
            UpdateBinding();
        }

        public void LateUpdate()
        {
            if (m_Binding == null)
            {
                return;
            }

            if (IsNeedUpdate() || m_IsDirty)
            {
                m_IsDirty = false;
                m_Binding.Update();
            }
        }
    }
}
