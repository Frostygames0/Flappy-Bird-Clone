using UnityEngine;

namespace FlappyBirdClone.UI
{
    public class SwitchableView : MonoBehaviour
    {
        public void Show()
            => gameObject.SetActive(true);

        public void Hide()
            => gameObject.SetActive(false);
    }
}