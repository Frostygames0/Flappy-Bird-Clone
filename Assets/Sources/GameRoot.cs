using FlappyBirdClone.Obstacles.Spawners;
using FlappyBirdClone.Player;
using FlappyBirdClone.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

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
            _bird.Kill();
            
            _losingMessageView.Show(_score.Total, 
                () => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex));
        }
        
        private void OnPassed()
            => _score.Increase();
    }
}