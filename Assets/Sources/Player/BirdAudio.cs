using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class BirdAudio : MonoBehaviour
    {
        [SerializeField] private Bird _bird;

        [SerializeField] private AudioSource _source;
        [SerializeField] private AudioClip _passSound;
        [SerializeField] private AudioClip _crashSound;

        private void OnEnable()
        {
            _bird.Crashed += OnCrashed;
            _bird.Passed += OnPassed;
        }

        private void OnDisable()
        {
            _bird.Crashed -= OnCrashed;
            _bird.Passed -= OnPassed;
        }

        private void OnPassed()
            => _source.PlayOneShot(_passSound);

        private void OnCrashed()
            => _source.PlayOneShot(_crashSound);
    }
}
