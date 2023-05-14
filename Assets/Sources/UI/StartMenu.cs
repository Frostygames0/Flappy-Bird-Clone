using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace FlappyBirdClone.UI
{
    public class StartMenu : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        
        private void OnEnable()
            => _startButton.onClick.AddListener(OnClick);

        private void OnDisable()
            => _startButton.onClick.RemoveListener(OnClick);

        private void OnClick()
            =>SceneManager.LoadScene(SceneConstants.GameScene);
    }
}
