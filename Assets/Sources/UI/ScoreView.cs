using FlappyBirdClone.Player;
using TMPro;
using UnityEngine;

namespace FlappyBirdClone.UI
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Score _score;
        [SerializeField] private TMP_Text _text;

        public void Show()
            => gameObject.SetActive(true);

        public void Hide()
            => gameObject.SetActive(false);

        private void OnEnable()
            => _score.Changed += OnChanged;
        
        private void OnDisable()
            => _score.Changed -= OnChanged;

        private void OnChanged(int newScore)
        {
            _text.SetText(newScore.ToString());
        }
    }
}