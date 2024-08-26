using System;
using UnityEngine;

namespace Demo.Scripts
{
    public class HideBone : MonoBehaviour
    {
        [SerializeField] private Transform bone;

        private void LateUpdate()
        {
            bone.localScale = Vector3.zero;
        }
    }
}
