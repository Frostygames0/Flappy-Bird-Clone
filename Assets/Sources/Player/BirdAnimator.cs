using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class BirdAnimator : MonoBehaviour
    {
        [SerializeField] private BirdMovement _birdMovement;
        
        [SerializeField] private Animator _animator;
        [SerializeField] private string _jumpAnimation;

        private void OnEnable()
            => _birdMovement.Flapped += PerformFlapAnimation;
        
        private void OnDisable()
            => _birdMovement.Flapped -= PerformFlapAnimation;

        private void PerformFlapAnimation()
            => _animator.Play(_jumpAnimation);
        
    }
}