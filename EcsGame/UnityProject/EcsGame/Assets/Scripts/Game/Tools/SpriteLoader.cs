using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;
using UnityEngine.UI;

namespace Game.Logic
{
    public static class SpriteLoader
    {
        public static Sprite GetSpriteByName(ResLoader resLoader, string newSpriteName)
        {
            UnityEngine.Object obj = resLoader.LoadSync(newSpriteName);
            Texture2D text = obj as Texture2D;
            Sprite sprite = null;

            if (text != null)
            {
                sprite = Sprite.Create(text, new Rect(0, 0, text.width, text.height), new Vector2(0.5f, 0.5f));
            }
            else
            {
                sprite = obj as Sprite;
            }
            //m_UILoader.Recycle2Cache();

            return sprite;
        }

        //public void ResetImageSprite(string newSpriteName, Image image)
        //{
        //    //if (m_UILoader == null)
        //    //{
        //    //    m_UILoader = ResLoader.Allocate("UI_UpgradePreviewLoader");
        //    //    Debug.Log("loaded init upgrade panel");
        //    //}
        //    var uiLoader = ResLoader.Allocate("SpriteLoader");

        //    UnityEngine.Object obj = uiLoader.LoadSync(newSpriteName);
        //    Texture2D text = obj as Texture2D;
        //    Sprite sprite = null;

        //    if (text != null)
        //    {
        //        sprite = Sprite.Create(text, new Rect(0, 0, text.width, text.height), new Vector2(0.5f, 0.5f));
        //    }
        //    else
        //    {
        //        sprite = obj as Sprite;
        //    }

        //    image.sprite = sprite;

        //    //uiLoader.ReleaseRes(newSpriteName);
        //    //uiLoader.Recycle2Cache();
        //}

    }
}
