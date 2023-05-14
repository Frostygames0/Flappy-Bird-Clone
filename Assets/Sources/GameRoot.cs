using FlappyBirdClone.Obstacles.Spawners;
using FlappyBirdClone.Player;
using FlappyBirdClone.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FlappyBirdClone
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private Bird _bird;
        [SerializeField] private Score _score;
        [SerializeField] private PipeSpawner _pipeSpawner;

        [SerializeField] private ScorePresenter _scorePresenter;
        [SerializeField] private LosingMessage _losingMessage;
        
#if UNITY_ANDROID
        [SerializeField] private int _androidFrameRate;
        
        private void Start()
            => Application.targetFrameRate = 60;
#endif

        private void OnEnable()
        {
            _bird.Crashed += OnCrashed;
            _bird.Passed += OnPassed;
            
            _pipeSpawner.StartSpawn();
        }

        private void OnDisable()
        {
            _bird.Crashed -= OnCrashed;
            _bird.Passed -= OnPassed;
        }
        
        private void OnCrashed()
        {
            _scorePresenter.Hide();
            _pipeSpawner.StopSpawn();
            
            _losingMessage.Show(_score.Total,
                () =>
                {
#if UNITY_EDITOR
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
#else
                    SceneManager.LoadScene(SceneConstants.StartScene);
#endif
                });
        }
        
        private void OnPassed()
            => _score.Increase();
    }
}