using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
   public static GameEvents gameEvents = null;

   public event Action OnDoorTriggerEnter;

   private void Awake()
   {
      if (gameEvents == null)
      {
         gameEvents = this;
      }
   }

   public void DoorTriggerEnter()
   {
      OnDoorTriggerEnter?.Invoke();
   }
   
}
