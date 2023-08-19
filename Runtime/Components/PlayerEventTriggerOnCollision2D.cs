using UnityEngine;
using UnityEngine.Events;

namespace FrozenPhoenixStudios.Components
{
    public class PlayerEventTriggerOnCollision2D : MonoBehaviour
    {
        [Header("On enter")]
        [SerializeField] private UnityEvent onCollisionEnter;
        [SerializeField] private bool enterRepeatable;
        [Header("On exit")]
        [SerializeField] private UnityEvent onCollisionExit;
        [SerializeField] private bool exitRepeatable;
        private bool _enterTriggered;
        private bool _exitTriggered;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!enterRepeatable && _enterTriggered) return;
            
            if (!other.CompareTag("PlayerHandler")) return;
            
            onCollisionEnter?.Invoke();
            _enterTriggered = true;

        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (!exitRepeatable && _exitTriggered) return;
            
            if (!other.CompareTag("PlayerHandler")) return;
            
            onCollisionExit?.Invoke();
            _exitTriggered = true;

        }
    }
}