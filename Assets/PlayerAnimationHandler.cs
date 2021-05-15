using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    
    public static PlayerAnimationHandler AnimationHandlerSingleton = null;

    private Animator playerAnimation;
    private void Awake()
    {
        if (AnimationHandlerSingleton == null)
        {
            AnimationHandlerSingleton = this;
        }
    }

    private void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    public void Move(bool isMoving)
    {
        playerAnimation.SetBool("IsMoving", isMoving);
    }
}
