using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FlappyBirdClone.UI
{
    public class LosingMessage : MonoBehaviour
    {
        [SerializeField] private TMP_Text _score;
        [SerializeField] private Button _restartButton;
        
        public void Show(int score, Action onRestart)
        {
            gameObject.SetActive(true);
            
            _score.SetText(score.ToString());
            
            _restartButton.onClick.RemoveAllListeners();
            _restartButton.onClick.AddListener(() => onRestart());
        }
    }
}