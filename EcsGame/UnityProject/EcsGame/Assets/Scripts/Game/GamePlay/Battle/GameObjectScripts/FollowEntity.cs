using Unity.Transforms;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class FollowEntity : MonoBehaviour
{
    public Entity EntityToFollow;
    public float3 Offset = Vector3.zero;

    private EntityManager m_Manager;

    private bool m_IsPlayerEntitySet;

    private void Awake()
    {
        m_Manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        m_IsPlayerEntitySet = false;
    }

    private void LateUpdate()
    {
        if (m_IsPlayerEntitySet == false && BattleMgr.S.BattleInited)
        {
            SetPlayerEntity();
        }

        if (EntityToFollow.Index <= 0)
        {
            return;
        }

        LocalTransform entityTransform = m_Manager.GetComponentData<LocalTransform>(EntityToFollow);
        transform.position = entityTransform.Position + Offset;
    }

    private void SetPlayerEntity()
    {
        //await UniTask.Delay(1000);
        EntityToFollow = GetPlayerEntity();
    }

    private Entity GetPlayerEntity()
    {
        var gameControllerQuery = m_Manager.CreateEntityQuery(ComponentType.ReadOnly<PlayerTag>());
        if (gameControllerQuery.IsEmpty)
            return default;

        return gameControllerQuery.GetSingletonEntity();
    }
}
