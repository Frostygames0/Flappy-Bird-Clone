using FlappyBirdClone.UI;
using TMPro;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class ScoreView : SwitchableView
    {
        [SerializeField] private Score _score;
        [SerializeField] private TMP_Text _text;

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