using UnityEngine;

namespace FlappyBirdClone.Settings
{
    [CreateAssetMenu(menuName = "Flappy Bird Clone/Moving Obstacle Spawner Settings")]
    public class ConstantlyMovableSpawnerSettings : ScriptableObject
    {
        [field: SerializeField] public float MinHeight { get; private set; }
        [field: SerializeField] public float MaxHeight { get; private set; }
        [field: SerializeField] public float SpawnInterval { get; private set; }
        [field: SerializeField] public float SpawnedSpeed { get; private set; }
    }
}