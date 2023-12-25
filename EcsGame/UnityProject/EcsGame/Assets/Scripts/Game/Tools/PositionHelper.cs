using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Logic
{
	public class PositionHelper
	{
        public static Vector2 ConverWorldPosToUIAnchorPos(Camera uiCamera, RectTransform parentRT,Vector3 worldPos)
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);

            Vector2 outVec;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRT, screenPos, uiCamera, out outVec);

            return outVec;
        }
	}
	
}