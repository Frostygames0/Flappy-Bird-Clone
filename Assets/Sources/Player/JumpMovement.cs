using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class JumpMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _jumpHeight;

        public void Init(float jumpHeight)
            => _jumpHeight = jumpHeight;
        
        public void Jump()
        {
            _rigidbody.velocity = Vector2.up * _jumpHeight;
        }
    }
}