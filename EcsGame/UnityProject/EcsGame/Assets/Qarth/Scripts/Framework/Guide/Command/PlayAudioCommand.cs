﻿





using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFrame
{
	public class PlayAudioCommand : AbstractGuideCommand
	{
		private string m_AudioName;
		private bool m_FinishStep = false;
		private int m_AudioID;

		public override void SetParam (object[] pv)
		{
			if (pv.Length == 0)
			{
				//Log.w ("PlayAudioCommand Init With Invalid Param.");
				return;
			}

			m_AudioName = (string)pv[0];
			if (pv.Length > 1)
			{
				m_FinishStep = Helper.String2Bool((string)pv[1]);
			}
		}

		protected override void OnStart()
		{
			m_AudioID = AudioMgr.S.PlaySound(m_AudioName, false, OnAoundPlayFinish);
		}

		private void OnAoundPlayFinish(int unit)
		{
			m_AudioID = -1;
			if (m_FinishStep)
			{
				FinishStep ();
			}
		}

		protected override void OnFinish(bool forceClean)
		{
			if (m_AudioID > 0)
			{
                AudioMgr.S.Stop(m_AudioID);
				m_AudioID = -1;
			}
		}

	}
}

