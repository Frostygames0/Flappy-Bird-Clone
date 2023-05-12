using System;
using FlappyBirdClone.Obstacles;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class Bird : MonoBehaviour
    {
        public event Action Crashed;
        public event Action Passed;

        public void Crash()
        {
            gameObject.SetActive(false);
            Crashed?.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if(col.TryGetComponent<SafetyZone>(out _))
                Passed?.Invoke();
        }
    }
}