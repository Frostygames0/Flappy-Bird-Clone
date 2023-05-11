using UnityEngine;

namespace FlappyBirdClone.Obstacles.Factory
{
    public class SimplePipeFactory : PipeFactory
    {
        [SerializeField] private Pipe _prefab;
        [SerializeField] private float _speed;

        public override Pipe Create(Vector3 position, Quaternion rotation)
        {
            var pipe = Instantiate(_prefab, position, rotation);
            
            pipe.Init(_speed);
            
            return pipe;
        }
    }
}