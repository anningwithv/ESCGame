﻿





using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFrame
{
    public class HighlightMaskPanel : AbstractPanel
    {
        private Action<int> m_OnSortingLayerUpdateListener;

		protected override void OnPanelOpen (params object[] args)
		{
            if (args.Length > 0)
            {
                m_OnSortingLayerUpdateListener = args[0] as Action<int>;
            }

            OnSortingLayerUpdate();
		}

        protected override void OnSortingLayerUpdate()
        {
            if (m_OnSortingLayerUpdateListener != null)
            {
                m_OnSortingLayerUpdateListener(m_SortingOrder);
            }
        }
    }
}
