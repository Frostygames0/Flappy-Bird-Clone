using UnityEngine;

namespace FlappyBirdClone.Settings
{
    [CreateAssetMenu(menuName = "Flappy Bird Clone/Decorations Settings")]
    public class DecorationsSettings : ScriptableObject
    {
        [field: SerializeField] public float BackgroundSpeed { get; private set; }
        [field: SerializeField] public float GroundSpeed { get; private set; }
    }
}