using NaughtyAttributes;
using UnityEngine;

namespace FlappyBirdClone.Settings
{
    [CreateAssetMenu(menuName = "Flappy Bird Clone/Game Settings")]
    public class GameSettings : ScriptableObject
    {
        [field: SerializeField, Expandable] public ConstantlyMovableSpawnerSettings SpawnerSettings { get; private set; }
        [field: SerializeField, Expandable] public JumpMovementSettings JumpSettings { get; private set; }
        [field: SerializeField, Expandable] public DecorationsSettings DecorationsSettings { get; private set; }
    }
}