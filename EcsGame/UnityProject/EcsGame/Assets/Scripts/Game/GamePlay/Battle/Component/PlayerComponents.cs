using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Entities;
using UnityEngine;

public struct PlayerTag : IComponentData
{ 
}

public struct PlayerConfig : IComponentData
{
    public float MoveSpeed;
}

public struct PlayerInput : IComponentData
{
    public float Horizontal;
    public float Vertical;
}

public class PlayerGameObjectPrefab : IComponentData
{
    public GameObject Value;
}

public class PlayerAnimatorReference : ICleanupComponentData
{
    public Animator Value;
}
