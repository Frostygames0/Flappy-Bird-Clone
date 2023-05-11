using UnityEngine;

namespace FlappyBirdClone.Obstacles
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private Vector2 _movementDirection;
        
        private float _speed;
        
        private void Awake()
            => _rigidbody.isKinematic = true;
        
        public void Init(float speed)
            => _speed = speed;
        
        private void FixedUpdate()
            => _rigidbody.velocity = _movementDirection * _speed;
    }
}