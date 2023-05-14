using UnityEngine;

namespace FlappyBirdClone.Player
{
    // Maybe make two classes one for movement and one for bird?
    public class BirdPresenter : MonoBehaviour
    {
        [SerializeField] private Bird _bird;
        [SerializeField] private BirdMovement _birdMovement;

        [SerializeField] private BirdAnimator _animator;
        [SerializeField] private BirdAudio _audio;

        private void OnEnable()
        {
            _birdMovement.Flapped += OnFlap;
            _bird.Crashed += OnCrashed;
            _bird.Passed += OnPassed;
        }

        private void OnDisable()
        {
            _birdMovement.Flapped -= OnFlap;
            _bird.Crashed -= OnCrashed;
            _bird.Passed -= OnPassed;
        }

        private void OnFlap()
            => _animator.PerformFlapAnimation();
        
        private void OnPassed()
            => _audio.PlayPassingSound();
        
        private void OnCrashed()
            => _audio.PlayCrashingSound();
    }
}