using UnityEngine;

namespace FlappyBirdClone.Settings
{
    [CreateAssetMenu(menuName = "Flappy Bird Clone/Jump Movement Settings")]
    public class JumpMovementSettings : ScriptableObject
    {
        [field: SerializeField] public float JumpHeight { get; private set; }
    }
}