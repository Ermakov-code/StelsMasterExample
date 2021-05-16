using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    
    private Animator playerAnimation;

    private void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    public void Move(bool isMoving)
    {
        playerAnimation.SetBool("IsMoving", isMoving);
    }
}
