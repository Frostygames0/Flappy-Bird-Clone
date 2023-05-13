using FlappyBirdClone.Player;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FlappyBirdClone.Input
{
    public class PlayerInput : MonoBehaviour, PlayerActions.IBirdActions
    {
        [SerializeField] private BirdMovement _birdMovement;

        private PlayerActions _actions;

        private void Awake()
        {
            _actions = new PlayerActions();
            _actions.Bird.SetCallbacks(this);
        }

        private void OnEnable()
            => _actions.Enable();

        private void OnDisable()
            => _actions.Disable();

        public void OnFlap(InputAction.CallbackContext context)
        {
            if (!context.performed) 
                return;

            _birdMovement.Flap();
        }
    }
}