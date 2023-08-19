using FrozenPhoenixStudios.Utilities;
using UnityEngine;

namespace FrozenPhoenixStudios.Components
{
    [AddComponentMenu("FrozenPhoenixStudios/Components/LookAtCamera")]
    public class LookAtCamera : MonoBehaviour
    {
        [SerializeField] private bool invert;
        private Transform _cameraTransform;

        private void Start() => _cameraTransform = HelperMethods.FindAndAssignMainCamera().transform;

        private void LateUpdate()
        {
            if (invert)
            {
                var position = transform.position;
                var cameraDirection = (_cameraTransform.position - position).normalized;
                transform.LookAt(position + cameraDirection * -1);
            }
            else
                transform.LookAt(_cameraTransform);
        }
    }
}