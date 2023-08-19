using UnityEngine;

namespace FrozenPhoenix.Components
{
    public class CollisionSensor2D : MonoBehaviour
    {
        [SerializeField] private float maxDistance;
        [SerializeField] private Vector2 direction;
        [SerializeField] private int maxResults;
        private RaycastHit2D[] hitResults;

        private void Awake () => hitResults = new RaycastHit2D[maxResults];

        [SerializeField] private ContactFilter2D contactFilter2D;

        public RaycastHit2D[] GetHitResults()
        {
            var hits = Physics2D.Raycast(transform.position, direction, contactFilter2D, hitResults, maxDistance) > 0;
            return hitResults;
        }
        
        private void OnDrawGizmos()
        {
            hitResults = new RaycastHit2D[maxResults];
            
            var hits = Physics2D.Raycast(transform.position, direction, contactFilter2D, hitResults, maxDistance);
            
            Gizmos.color = hits > 0 ? Color.green : Color.red;
            
            Gizmos.DrawRay(transform.position, direction * maxDistance);
            
        }
    }
}