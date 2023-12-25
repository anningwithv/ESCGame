





using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

namespace GameFrame
{
    public interface ISkillReleaser
    {
        void OnSkillRelease(ISkill skill);
        void OnSkillRemove(ISkill skill);
    }
}
