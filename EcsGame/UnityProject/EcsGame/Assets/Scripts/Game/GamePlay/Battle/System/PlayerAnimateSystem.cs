using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

//[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
//public partial struct PlayerAnimateSystem : ISystem
//{
//    public void OnUpdate(ref SystemState state)
//    {
//        var ecb = new EntityCommandBuffer(Allocator.Temp);

//        foreach (var (playerGameObjectPrefab, entity) in
//                 SystemAPI.Query<PlayerGameObjectPrefab>().WithNone<PlayerAnimatorReference>().WithEntityAccess())
//        {
//            var newCompanionGameObject = Object.Instantiate(playerGameObjectPrefab.Value);
//            var newAnimatorReference = new PlayerAnimatorReference
//            {
//                Value = newCompanionGameObject.GetComponent<Animator>()
//            };
//            ecb.AddComponent(entity, newAnimatorReference);
//        }

//        foreach (var (transform, animatorReference, moveInput) in
//                 SystemAPI.Query<LocalTransform, PlayerAnimatorReference, MoveInput>())
//        {
//            animatorReference.Value.SetBool("IsMoving", math.length(moveInput.Value) > 0f);
//            animatorReference.Value.transform.position = transform.Position;
//            animatorReference.Value.transform.rotation = transform.Rotation;
//        }

//        foreach (var (animatorReference, entity) in
//                 SystemAPI.Query<PlayerAnimatorReference>().WithNone<PlayerGameObjectPrefab, LocalTransform>()
//                     .WithEntityAccess())
//        {
//            Object.Destroy(animatorReference.Value.gameObject);
//            ecb.RemoveComponent<PlayerAnimatorReference>(entity);
//        }

//        ecb.Playback(state.EntityManager);
//        ecb.Dispose();
//    }
//}
