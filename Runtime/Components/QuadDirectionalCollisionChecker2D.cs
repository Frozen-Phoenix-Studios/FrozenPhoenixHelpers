using UnityEngine;
using UnityEngine.Serialization;

namespace FrozenPhoenixStudios.Components
{
    public class QuadDirectionalCollisionChecker2D : MonoBehaviour
    {
        [FormerlySerializedAs("upSensor")] [SerializeField] private CollisionSensor2D[] upSensorArray;
        [FormerlySerializedAs("downSensoArray")] [FormerlySerializedAs("downSensor")] [SerializeField] private CollisionSensor2D[] downSensorArray;
        [SerializeField] private CollisionSensor2D[] leftSensorArray;
        [FormerlySerializedAs("rightSensor")] [SerializeField] private CollisionSensor2D[] rightSensorArray;

        public bool UpColliding { get; private set; }
        public bool DownColliding { get; private set; }
        public bool LeftColliding { get; private set; }
        public bool RightColliding { get; private set; }

        // private void Update() => CheckForCollisions();

        // private void CheckForCollisions()
        // {
        //     UpColliding = CheckForAnyCollision(upSensorArray);
        //     DownColliding = CheckForAnyCollision(downSensorArray);
        //     LeftColliding = CheckForAnyCollision(leftSensorArray);
        //     RightColliding = CheckForAnyCollision(rightSensorArray);
        // }
        //
        // private bool CheckForAnyCollision(CollisionSensor2D[] sensor2DArray)
        // {
        //     foreach (var sensor in sensor2DArray)
        //     {
        //         foreach (var hit in sensor.GetHitResults())
        //         {
        //             if (hit.collider != null)
        //             {
        //                 return true;
        //             }
        //         }
        //     }
        //     return false;
        // }

        public RaycastHit2D GetFirstUpCollision() => GetFirstCollision(upSensorArray);
        public RaycastHit2D GetFirstDownCollision() => GetFirstCollision(downSensorArray);
        public RaycastHit2D GetFirstLeftCollision() => GetFirstCollision(leftSensorArray);
        public RaycastHit2D GetFirstRightCollision() => GetFirstCollision(rightSensorArray);

        private static RaycastHit2D GetFirstCollision(CollisionSensor2D[] sensorArray)
        {
            foreach (var sensor in sensorArray)
            {
                foreach (var hit in sensor.GetHitResults())
                {
                    if (hit.collider != null)
                        return hit;
                }
            }

            return new RaycastHit2D();
        }
        
        
    }
}