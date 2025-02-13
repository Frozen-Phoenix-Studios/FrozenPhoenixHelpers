using System;
using UnityEngine;

namespace FrozenPhoenix.Components
{
    [AddComponentMenu("FrozenPhoenixStudios/Components/FPSAnimationEventListener")]
    public abstract class FPSAnimationEventListenerBase : MonoBehaviour
    {
        //attacks
        public event Action OnAttackStart;
        public event Action OnAttackDamageTrigger;
        public event Action OnAttackComplete;

        //damage
        public event Action OnHurtStart;
        public event Action OnHurtComplete;

        //death
        public event Action OnDeathStart;
        public event Action OnDeathComplete;

        public void CallOnAttackStart() => OnAttackStart?.Invoke();
        
        public void CallOnAttackDamageTrigger() => OnAttackDamageTrigger?.Invoke();

        public void CallOnAttackComplete() => OnAttackComplete?.Invoke();

        public void CallOnHurtStart() => OnHurtStart?.Invoke();

        public void CallOnHurtComplete() => OnHurtComplete?.Invoke();

        public void CallOnDeathStart() => OnDeathStart?.Invoke();

        public void CallOnDeathComplete() => OnDeathComplete?.Invoke();
    }

    public class FPSAnimationEventListener : FPSAnimationEventListenerBase
    {
    }
}
