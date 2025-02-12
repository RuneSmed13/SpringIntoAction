
using UnityEngine;

namespace KitKat.Examples.ZeldaCameraSystem.Runtime
{
    public class CamController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Transform player;

        [Header("Settings")]
        [SerializeField] private Vector2 roomSize;
        [SerializeField] private float cameraOffsetZ = -10.6f;


        private void Awake()
        {
            SnapToGrid();
        }

        private void LateUpdate()
        {
            SnapToGrid();
        }

        private void SnapToGrid()
        {
            Vector2 playerPosition = player.position;
            Vector2 snappedPosition = playerPosition.Floor(roomSize);

            transform.position = snappedPosition * roomSize + roomSize / 2;
            transform.position += cameraOffsetZ * Vector3.forward;
        }
    }
}