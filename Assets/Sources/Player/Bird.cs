using System;
using FlappyBirdClone.Obstacles;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class Bird : MonoBehaviour
    {
        public event Action Crashed;
        public event Action Passed;

        public void Kill()
            => gameObject.SetActive(false);

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.collider.TryGetComponent<Obstacle>(out _))
                Crashed?.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if(col.TryGetComponent<SafetyZone>(out _))
                Passed?.Invoke();
        }
    }
}