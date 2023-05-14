using System.Collections;
using FlappyBirdClone.Obstacles.Factory;
using UnityEngine;

namespace FlappyBirdClone.Obstacles.Spawners
{
    // TODO Use object pool
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] private PipeFactory _pipeFactory;

        [SerializeField] private float _minHeight;
        [SerializeField] private float _maxHeight;
        [SerializeField] private float _spawnInterval;

        private Coroutine _continuousSpawnRoutine;
        
        public void StartSpawn()
        {
            _continuousSpawnRoutine = StartCoroutine(ContinuouslySpawn());
        }
        
        public void StopSpawn()
        {
            if(_continuousSpawnRoutine != null)
                StopCoroutine(_continuousSpawnRoutine);
        }
        
        private void Spawn()
        {
            var position = DeterminePosition();
            _pipeFactory.Create(position, Quaternion.identity);
        }
        
        private IEnumerator ContinuouslySpawn()
        {
            while (true)
            {
                Spawn();
                yield return new WaitForSeconds(_spawnInterval);
            }
        }
        
        private Vector3 DeterminePosition()
        {
            var randomHeight = Random.Range(_minHeight, _maxHeight);
                        
            var newPosition = transform.position;
            newPosition.y = randomHeight;
                        
            return newPosition;
        }
    }
}