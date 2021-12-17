using UnityEngine;

namespace ARVideoPlayer
{
    public class AnimationController : MonoBehaviour
    {
        private int _animatorDancingHash = Animator.StringToHash("Dancing");
        private int _animatorIdleHash = Animator.StringToHash("Idle");

        public void PlayDancingAnimation(Animator animator)
        {
            animator.Play(_animatorDancingHash);
        }

        public void PlayIdleAnimation(Animator animator)
        {
            animator.Play(_animatorIdleHash);
        }
    }
}
