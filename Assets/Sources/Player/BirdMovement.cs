using System;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class BirdMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _flapHeight;

        public event Action Flapped;
        
        public void Flap()
        {
            _rigidbody.velocity = Vector2.up * _flapHeight;
            Flapped?.Invoke();
        }
    }
}