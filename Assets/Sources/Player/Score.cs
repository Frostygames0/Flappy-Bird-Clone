using System;
using UnityEngine;

namespace FlappyBirdClone.Player
{
    public class Score : MonoBehaviour
    {
        public int Total { get; private set; }

        public event Action<int> Changed;

        public void Increase()
        {
            Total += 1;
            Changed?.Invoke(Total);
        }
    }
}