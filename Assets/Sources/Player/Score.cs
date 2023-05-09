using System;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class Score : MonoBehaviour
    {
        private int _score;

        public event Action<int> Changed;

        public void Increase()
        {
            _score += 1;
            Changed?.Invoke(_score);
        }
    }
}