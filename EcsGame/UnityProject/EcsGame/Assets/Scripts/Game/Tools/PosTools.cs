using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;
namespace Game.Logic
{  
    public class PosTools : TSingleton<PosTools> 
    {
        public static Vector2 ConvertWorldToUIPos(Vector3 worldPos, Canvas canvas)
        {
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform,
                Camera.main.WorldToScreenPoint(worldPos),
                canvas.worldCamera,
                out pos);

            return pos;
        }
    }
}