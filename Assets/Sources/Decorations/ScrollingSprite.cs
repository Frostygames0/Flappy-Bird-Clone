using UnityEngine;

namespace FlappyBirdClone.Decorations
{
    public class ScrollingSprite : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Vector2 _movementDirection;

        [SerializeField] private float _speed;

        private void Update()
        {
            _spriteRenderer.material.mainTextureOffset += _movementDirection * (_speed * Time.deltaTime);
        }
    }
}