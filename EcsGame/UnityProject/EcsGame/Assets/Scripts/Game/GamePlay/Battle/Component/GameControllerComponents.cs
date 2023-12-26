using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct GameControllerTag : IComponentData
{
}

public struct GameStartTag : IComponentData
{
}

public struct GameConfig : IComponentData
{
    public Entity PlayerPrefab;
    public Entity EnemyPrefab;
}

public struct GameControllerRandom : IComponentData
{
    public Unity.Mathematics.Random Value;
}
