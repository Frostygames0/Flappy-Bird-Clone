using TMPro;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class ScorePresenter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private AudioSource _source;

        [SerializeField] private Score _score;

        private void OnEnable()
            => _score.Changed += OnChanged;
        
        private void OnDisable()
            => _score.Changed -= OnChanged;

        private void OnChanged(int newScore)
        {
            _text.SetText(newScore.ToString());
            _source.Play();
        }
    }
}