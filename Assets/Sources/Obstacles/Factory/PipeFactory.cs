using UnityEngine;

namespace FlappyBirdClone.Obstacles.Factory
{
    public abstract class PipeFactory : MonoBehaviour
    {
        public abstract Pipe Create(Vector3 position, Quaternion rotation);
    }
}