using GameFrame;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : AbstractPanel
{
    [SerializeField] private Button m_StartBtn;

    protected override void OnUIInit()
    {
        base.OnUIInit();

        m_StartBtn.onClick.AddListener(() => {
            GameplayMgr.S.ChangeState(Game.Logic.GameStateID.Battle);
        });
    }

    protected override void OnPanelOpen(params object[] args)
    {
        base.OnPanelOpen(args);
    }


}

