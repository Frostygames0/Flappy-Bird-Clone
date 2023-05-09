﻿using UnityEngine;

namespace FlappyBirdClone.Decorations
{
    public class ScrollingSprite : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Vector2 _movement;

        [SerializeField] private float _speed;
        private bool _paused;

        public void Init(float speed)
            => _speed = speed;
        
        private void Update()
        {
            _spriteRenderer.material.mainTextureOffset += _movement * (_speed * Time.deltaTime);
        }

    }
}