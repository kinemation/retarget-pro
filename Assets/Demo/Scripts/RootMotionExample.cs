// Designed by KINEMATION, 2024.

using UnityEngine;

namespace Demo.Scripts
{
    public class RootMotionExample : MonoBehaviour
    {
        [SerializeField] private AnimationClip clip;
        
        private Animator _animator;
        private Vector3 _defaultPosition;
        private Quaternion _defaultRotation;

        private float _length;

        private void ResetRootMotion()
        {
            transform.position = _defaultPosition;
            transform.rotation = _defaultRotation;
            
            _animator.Rebind();
            _animator.Play(clip.name);
            
            Invoke(nameof(ResetRootMotion), _length);
        }

        private void Start()
        {
            _length = clip.length;
            
            _defaultPosition = transform.position;
            _defaultRotation = transform.rotation;
            
            _animator = GetComponent<Animator>();
            ResetRootMotion();
        }
    }
}
