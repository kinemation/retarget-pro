using KINEMATION.KAnimationCore.Runtime.Attributes;
using KINEMATION.KAnimationCore.Runtime.Rig;
using UnityEngine;

namespace Demo.Scripts
{
    [CreateAssetMenu(fileName = "NewTestAsset", menuName = "TestAsset")]
    public class TestAsset : ScriptableObject
    {
        [HideInInspector] public AvatarMask avatarMask;
        [HideInInspector] public KRig rig;
    }
}