using System;
using FrozenPhoenix.Utilities;
using UnityEngine;

namespace FrozenPhoenix.Components
{

    public abstract class FPSAnimationControllerBase : MonoBehaviour
    {
        public enum AnimationTriggers
        {
            All,
            Attack,
            Damage,
            Jump
        }

       [SerializeField] protected Animator _anim;

        //moving
        private static readonly int Speed = Animator.StringToHash("Speed");
        private static readonly int Walking = Animator.StringToHash("Walking");
        private static readonly int Idle = Animator.StringToHash("Idle");
        
        //attacking
        private static readonly int Attack = Animator.StringToHash("Attack");
        private static readonly int Shoot = Animator.StringToHash("Shoot");
        
        //damage
        private static readonly int Damaged = Animator.StringToHash("Damaged");
        private static readonly int Dead = Animator.StringToHash("Dead");

        
        //jumping
        private static readonly int Jumping = Animator.StringToHash("Jumping");
        private static readonly int Falling = Animator.StringToHash("Falling");
        private static readonly int Landing = Animator.StringToHash("Landing");

        private const float IDLE_SPEED = 0;
        private const float WALK_SPEED = 0.5f;
        private const float RUN_SPEED = 1f;

        public void Awake()
        {
            if (_anim != null) return;
            
            HelperMethods.CheckAndAssignComponent(ref _anim, gameObject, false);

            if (_anim == null)
                HelperMethods.CheckAndAssignComponentInChild(ref _anim, gameObject);

        }

        //moving
            //floats
            public void SetToIdleSpeed() => _anim.SetFloat(Speed, IDLE_SPEED);
            public void SetToWalkSpeed() => _anim.SetFloat(Speed, WALK_SPEED);
 
            //bools
            public void ToggleWalking(bool isWalking) => _anim.SetBool(Walking, isWalking);

            public void ToggleIdle(bool isIdle) => _anim.SetBool(Idle, isIdle);
            
            //todo: might need a method which takes a float;


        //attacking
        public void TriggerAttackState() => _anim.SetTrigger(Attack);
        public void TriggerShootState() => _anim.SetTrigger(Shoot);
        
        //damage
            //triggers
            public void TriggerDamagedState() => _anim.SetTrigger(Damaged);
            public void TriggerDeathState() => _anim.SetTrigger(Dead);
            //bools
            public void ToggleDamagedState(bool isDamaged) => _anim.SetBool(Damaged, isDamaged);
            public void ToggleDeathState(bool isDead) => _anim.SetBool(Dead, isDead);

        //Jumping
            //triggers
            public void TriggerJumpState() => _anim.SetTrigger(Jumping);
            public void TriggerFallState() => _anim.SetTrigger(Falling);
            public void TriggerLandState() => _anim.SetTrigger(Landing);

            //bools
            public void ToggleJumpState(bool isJumping) => _anim.SetBool(Jumping, isJumping);


            public void ResetTrigger(AnimationTriggers triggerToReset)
        {
            switch (triggerToReset)
            {
                case AnimationTriggers.All:
                    SetToIdleSpeed();
                    _anim.ResetTrigger(Attack);
                    _anim.ResetTrigger(Damaged);
                    _anim.ResetTrigger(Dead);
                    _anim.ResetTrigger(Jumping);
                    _anim.ResetTrigger(Falling);
                    _anim.ResetTrigger(Landing);
                    break;
                
                case AnimationTriggers.Attack:
                    _anim.ResetTrigger(Attack);
                    break;
                
                case AnimationTriggers.Damage:
                    _anim.ResetTrigger(Damaged);
                    _anim.ResetTrigger(Dead);
                    break;
                
                case AnimationTriggers.Jump:
                    _anim.ResetTrigger(Jumping);
                    _anim.ResetTrigger(Falling);
                    _anim.ResetTrigger(Landing);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(triggerToReset), triggerToReset, null);
            }
        }
    }

}