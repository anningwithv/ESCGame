using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameFrame;

namespace Game.Logic
{
    public class CommonResModule : AbstractModule
    {
        protected override void OnComAwake()
        {

            HolderCommondAudio();


            ResHolder.S.loader.LoadSync();

        }

        private void HolderCommondAudio()
        {
            //ResHolder.S.AddRes(TDConstTable.QueryString(ConstType.MUSIC_BG));
            //SoundButton.defaultClickSound = Define.SOUND_DEFAULT_UI_BTN;

            //ResHolder.S.AddRes(Define.SOUND_DEFAULT_SOUND);
            //ResHolder.S.AddRes(Define.SOUND_LOGO_BGM);
            //ResHolder.S.AddRes(Define.SOUND_CLASSIC_MODE_BGM);
            //ResHolder.S.AddRes(Define.SOUND_CLEAR_NORMAL);
            //ResHolder.S.AddRes(Define.SOUND_CLEAR_5);
            //ResHolder.S.AddRes(Define.SOUND_CLEAR_6);
            //ResHolder.S.AddRes(Define.SOUND_CLEAR_7);
            //ResHolder.S.AddRes(Define.SOUND_CLEAR_CUBE);
            //ResHolder.S.AddRes(Define.SOUND_LEVEL_COMPLETE);
            //ResHolder.S.AddRes(Define.SOUND_LOGO_BTN);
            //ResHolder.S.AddRes(Define.SOUND_PUT_CUBE);

        //ResHolder.S.AddRes(TDConstTable.QueryString(ConstType.SOUND_CLICK_RIGHT));
        //ResHolder.S.AddRes(TDConstTable.QueryString(ConstType.SOUND_CLICK_WRONG));

        //ResHolder.S.AddRes(TDConstTable.QueryString(ConstType.SOUND_WIN));
        //ResHolder.S.AddRes(TDConstTable.QueryString(ConstType.SOUND_FAILED));


    }

    }
}
