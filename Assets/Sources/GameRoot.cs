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

        [SerializeField] private ScoreView _scoreView;
        [SerializeField] private LosingMessageView _losingMessageView;

        private void OnEnable()
        {
            _pipeSpawner.StartSpawn();
            _bird.Crashed += OnCrashed;
            _bird.Passed += OnPassed;
        }

        private void OnDisable()
        {
            _bird.Crashed -= OnCrashed;
            _bird.Passed -= OnPassed;
        }
        
        private void OnCrashed()
        {
            _scoreView.Hide();
            _pipeSpawner.StopSpawn();
            
            _losingMessageView.Show(_score.Total,
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