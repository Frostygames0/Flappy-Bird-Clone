﻿using FlappyBirdClone.Player;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FlappyBirdClone.Input
{
    public class InputRouter : MonoBehaviour, PlayerActions.IBirdActions
    {
        [SerializeField] private JumpMovement _jumpMovement;
        [SerializeField] private JumpAnimator _jumpAnimator;
        
        private PlayerActions _actions;

        private void Awake()
        {
            _actions = new PlayerActions();
            _actions.Bird.SetCallbacks(this);
        }

        private void OnEnable()
            => _actions.Bird.Enable();

        private void OnDisable()
            => _actions.Bird.Disable();

        public void OnJump(InputAction.CallbackContext context)
        {
            if (!context.performed) 
                return;
            
            _jumpMovement.Jump();
            _jumpAnimator.PerformJumpAnimation();
        }
    }
}