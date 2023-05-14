using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class BirdAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _flapAnimation;

        public void PerformFlapAnimation()
            => _animator.Play(_flapAnimation);
    }
}