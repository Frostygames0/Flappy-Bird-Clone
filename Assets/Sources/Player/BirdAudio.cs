using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class BirdAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource _source;
        [SerializeField] private AudioClip _passSound;
        [SerializeField] private AudioClip _crashSound;

        public void PlayPassingSound()
            => _source.PlayOneShot(_passSound);

        public void PlayCrashingSound()
            => _source.PlayOneShot(_crashSound);
    }
}
