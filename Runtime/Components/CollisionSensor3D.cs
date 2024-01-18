using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrozenPhoenix.Components
{
    public class CollisionSensor3D : MonoBehaviour
    {
        [SerializeField] private float maxDistance;
        [SerializeField] private Vector3 direction;

        [SerializeField] private int maxResults;
        private RaycastHit[] _hitResults;

        [SerializeField] private LayerMask layerMask;

        [SerializeField] private bool showGizmos;

        [SerializeField] private QueryTriggerInteraction queryTriggerInteraction;

        private void Awake() => _hitResults = new RaycastHit[maxResults];

        public RaycastHit[] GetHitResults()
        {
            Physics.RaycastNonAlloc(transform.position, direction, _hitResults, maxDistance, layerMask,
                queryTriggerInteraction);

            return _hitResults;
        }

        private void OnDrawGizmosSelected()
        {
            if (!showGizmos || maxResults < 1) return;

            _hitResults = new RaycastHit[maxResults];

            var position = transform.position;
            Physics.RaycastNonAlloc(position, direction, _hitResults, maxDistance, layerMask,
                queryTriggerInteraction);

            Gizmos.color = _hitResults[0].collider != null ? Color.green : Color.red;

            Gizmos.DrawRay(position, direction * maxDistance);
        }
    }
}