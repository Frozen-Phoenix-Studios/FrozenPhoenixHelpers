using FrozenPhoenix.DataStructures;
using UnityEngine;

namespace FrozenPhoenix.Components
{
    public class GroundCheck2D : MonoBehaviour
    {
        public bool IsGrounded { get; private set; }

        [SerializeField] private Transform[] groundSensors;
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private float maxCheckDistance = 0.2f;

        private void Update()
        {
            IsGrounded = RaycastFromAllSensors();
        }

        private bool RaycastFromSensor(Transform sensor)
        {
            RaycastHit2D hit;
            var position = sensor.position;
            var forward = Vector2.down;

            hit = Physics2D.Raycast(position, forward, maxCheckDistance, groundLayer);

            Debug.DrawRay(position, forward * maxCheckDistance, Color.green);

            bool didHit = hit.collider != null;

            Debug.DrawRay(position, forward * maxCheckDistance, didHit ? Color.green : Color.red);

            return didHit;
        }

        //todo: this could be made better
        private bool RaycastFromAllSensors()
        {
            var grounded = false;

            for (int i = 0; i < groundSensors.Length; i++)
            {
                if (grounded)
                    RaycastFromSensor(groundSensors[i]);
                else grounded = RaycastFromSensor(groundSensors[i]);
            }

            return grounded;
        }
    }
}