﻿using FlappyBirdClone.Player;
using UnityEngine;

namespace FlappyBirdClone.Obstacles
{
    public class Obstacle : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.TryGetComponent(out Bird bird))
                bird.Crash();
        }
    }
}