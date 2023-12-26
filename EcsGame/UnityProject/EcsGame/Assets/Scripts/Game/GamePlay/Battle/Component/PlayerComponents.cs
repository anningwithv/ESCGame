using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Entities;
using UnityEngine;

public class PlayerComponents
{
    public struct PlayerTag : IComponentData
    { 
    }

    public struct PlayerConfig : IComponentData
    {
        public float MoveSpeed;
    }
}
