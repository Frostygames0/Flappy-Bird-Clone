using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FlappyBirdClone.Obstacles.Spawners
{
    public class ConstantlyMovableSpawner : MonoBehaviour
    {
        [SerializeField] private ConstantlyMovable _prefab;
        
        [SerializeField] private float _minHeight;
        [SerializeField] private float _maxHeight;
        
        [SerializeField, Min(0)] private float _spawnInterval;
        [SerializeField] private float _spawnedSpeed;

        private Coroutine _continuousSpawn;

        public void Init(float minHeight, float maxHeight, float spawnInterval, float spawnedSpeed)
        {
            _minHeight = minHeight;
            _maxHeight = maxHeight;
            _spawnInterval = spawnInterval;
            _spawnedSpeed = spawnedSpeed;
        }

        public void StartSpawn()
            => _continuousSpawn = StartCoroutine(ContinuouslySpawnTubes());
        
        public void StopSpawn()
            => StopCoroutine(_continuousSpawn);
        
        private IEnumerator ContinuouslySpawnTubes()
        {
            while (true)
            {
                SpawnTube();
                yield return new WaitForSeconds(_spawnInterval);
            }
        }
        
        private void SpawnTube()
        {
            var tube = Instantiate(_prefab, DetermineNewPosition(), Quaternion.identity);
            tube.Init(_spawnedSpeed);
        }

        private Vector2 DetermineNewPosition()
        {
            var randomHeight = Random.Range(_minHeight, _maxHeight);
            
            var newPosition = transform.position;
            newPosition.y = randomHeight;
            
            return newPosition;
        }
    }
}