using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Game.Logic;
using UnityEngine;
using GameFrame;
using UnityEngine.UI;

public class SkipGuidePanel : AbstractPanel
{
    [SerializeField]
    private Transform m_SkipButton;

    [SerializeField] private Text m_Text0;

    protected override void OnOpen()
    {
        base.OnOpen();
        //Log.w("=====skip guide=====");
        
        DOTween.Sequence()
            .Append(m_Text0.DOFade(0.1f, 1f))
            .Append(m_Text0.DOFade(1, 1.5f)).SetLoops(-1);
    } 
}
