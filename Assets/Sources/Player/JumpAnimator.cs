using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class JumpAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _jumpAnimation;
        
        public void PerformJumpAnimation()
        {
            _animator.Play(_jumpAnimation);
        }
    }
}