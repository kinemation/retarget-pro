using UnityEngine;

namespace Demo.Scripts
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 1f;
    
        private void Update()
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0f, 0f);
        }
    }
}
