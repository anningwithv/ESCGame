





using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public enum EngineEventID
    {
        EngineEventIDMin = 1000000,
        OnPanelUpdate,

        OnApplicationFocusChange,
        OnApplicationPauseChange,
        OnAfterApplicationPauseChange,
        OnAfterApplicationFocusChange,

        OnApplicationQuit,

        BackKeyDown,
        OnShare2Social,
        OnAchievementComplate,
        OnAchievementFinish,

        OnDateUpdate,//日期更新
        OnSignStateChange,

        OnShareCaptureBegin,
        OnShareCaptureEnd,
        OnLanguageChange,
        OnLanguageTableSwitchFinish,
        OnNeedShowBanner,
        OnNeedHideBanner,
        ///////////////

        OnRealNameValidOver18,
    }
}
