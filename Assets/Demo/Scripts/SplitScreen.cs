// Designed by KINEMATION, 2024.

using UnityEngine;

namespace Demo.Scripts
{
    public class SplitScreen : MonoBehaviour
    {
        public Camera cameraA;
        public Camera cameraB;
    
        private void Start()
        {
            var cameraRect = cameraA.rect;

            float offset = cameraRect.width / 2f;
            cameraRect.width = offset;

            cameraA.rect = cameraRect;

            cameraRect.x += offset;
            cameraB.rect = cameraRect;
        }
    }
}
