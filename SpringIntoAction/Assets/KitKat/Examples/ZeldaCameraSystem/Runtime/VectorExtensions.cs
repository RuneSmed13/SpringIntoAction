
using UnityEngine;

namespace KitKat.Examples.ZeldaCameraSystem.Runtime
{
    public static class VectorExtensions
    {
        public static Vector2 Floor(this Vector2 input, Vector2 toFloorBy)
        {
            Vector2 divided = input / toFloorBy;

            return new Vector2(
                Mathf.FloorToInt(divided.x),
                Mathf.FloorToInt(divided.y)
            );
        }
    }
}