using UnityEngine;

namespace FrozenPhoenix.Components
{
    public class DestroyAfterTime : MonoBehaviour
    {
        [SerializeField] private float destructionDelay = 0.9f;

        private void Start() => Destroy(gameObject, destructionDelay);
    }
}