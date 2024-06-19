// Designed by KINEMATION, 2024.

using UnityEngine;
using UnityEngine.Playables;

namespace Demo.Scripts
{
    public class FPSAnimationPlayer : MonoBehaviour
    {
        public Animator characterAnimator;
        public Animator weaponAnimator;

        public AnimationClip characterAnimation;
        public AnimationClip weaponAnimation;

        private PlayableGraph _characterGraph;
        private PlayableGraph _weaponGraph;
    
        private void PlayAnimation()
        {
            DisposeGraphs();
            
            characterAnimator.Rebind();
            weaponAnimator.Rebind();
            
            AnimationPlayableUtilities.PlayClip(characterAnimator, characterAnimation, out _characterGraph);
            AnimationPlayableUtilities.PlayClip(weaponAnimator, weaponAnimation, out _weaponGraph);
        
            Invoke(nameof(PlayAnimation), characterAnimation.length);
        }
    
        private void Start()
        {
            PlayAnimation();
        }

        private void DisposeGraphs()
        {
            if (_characterGraph.IsValid())
            {
                _characterGraph.Stop();
                _characterGraph.Destroy();
            }

            if (_weaponGraph.IsValid())
            {
                _weaponGraph.Stop();
                _weaponGraph.Destroy();
            }
        }

        private void OnDestroy()
        {
            DisposeGraphs();
        }
    }
}
