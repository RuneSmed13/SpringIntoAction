
using UnityEngine;

namespace KitKat.Examples.ZeldaCameraSystem.Runtime
{
    public class CameraSmoothing : MonoBehaviour
    {
        [Tooltip("Where the camera wants to be.")]
        [SerializeField] private Transform target;
        [Tooltip("Approximately the time it will take to reach the target. A smaller value will reach the target faster.")]
        [SerializeField] private float smoothSpeed;

        private Vector3 currentVelocity = Vector3.zero;

        private void Start()
        {
            transform.position = target.position;
        }

        private void Update()
        {
            transform.position = Vector3.SmoothDamp(transform.position, target.position, ref currentVelocity, smoothSpeed);
        }
    }
}