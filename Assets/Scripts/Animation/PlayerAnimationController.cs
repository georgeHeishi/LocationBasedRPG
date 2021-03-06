﻿using UnityEngine;

namespace LocationRPG
{
    public class PlayerAnimationController : AnimationController
    {
        public PlayerAnimationController(Animator _animator, string _currentAnimation) : base(_animator,
            _currentAnimation)
        {
            //super constructor   
        }

        public void ToggleWalking()
        {
            ChangeAnimation(AnimationConstants.PLAYER_WALKING);
        }

        public void ToggleIdle()
        {
            ChangeAnimation(AnimationConstants.PLAYER_IDLE);
        }
    }
}