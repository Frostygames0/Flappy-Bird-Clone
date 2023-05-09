using FlappyBirdClone.Decorations;
using FlappyBirdClone.Obstacles.Spawners;
using FlappyBirdClone.Player;
using FlappyBirdClone.Settings;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace FlappyBirdClone
{
    public class GameRoot : MonoBehaviour
    {
        [Header("Player")]
        [SerializeField] private Bird _crashable;
        [SerializeField] private JumpMovement _jumpMovement;
        [SerializeField] private Score _score;
        
        [Header("Spawners")]
        [SerializeField] private ConstantlyMovableSpawner _constantMovingObjectSpawner;
        
        [Header("Decorations")]
        [SerializeField] private ScrollingSprite _ground;
        [SerializeField] private ScrollingSprite _background;
        
        [Header("Settings")]
        [SerializeField] private GameSettings _settings;

        private void Awake()
        {
            InitializeBird();
            InitializeSpawners();
            InitializeDecorations();
        }

        private void InitializeSpawners()
        {
            var spawnerSettings = _settings.SpawnerSettings;
            _constantMovingObjectSpawner.Init(spawnerSettings.MinHeight, spawnerSettings.MaxHeight, spawnerSettings.SpawnInterval, spawnerSettings.SpawnedSpeed);
        }

        private void InitializeBird()
        {
            var jumpSettings = _settings.JumpSettings;
            _jumpMovement.Init(jumpSettings.JumpHeight);
        }

        private void InitializeDecorations()
        {
            var decorationsSettings = _settings.DecorationsSettings;
            
            _ground.Init(decorationsSettings.GroundSpeed);
            _background.Init(decorationsSettings.BackgroundSpeed);
        }

        private void OnEnable()
        {
            _constantMovingObjectSpawner.StartSpawn();
            _crashable.Crashed += OnCrashed;
            _crashable.Passed += OnPassed;
        }

        private void OnDisable()
        {
            _constantMovingObjectSpawner.StopSpawn();
            _crashable.Crashed -= OnCrashed;
            _crashable.Passed -= OnPassed;
        }
        
        // TODO Implement proper losing sequence
        private void OnCrashed()
            => SceneManager.LoadScene(0);
        
        private void OnPassed()
            => _score.Increase();
    }
}