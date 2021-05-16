using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
   public static Predicate<int> allKetCollected;
   
   private void OnTriggerEnter(Collider other)
   {
      if (allKetCollected?.Invoke(PlayerInventory.singleton.CurrentKeyCount) ?? false)
      {
         GameEvents.gameEvents.DoorTriggerEnter();
      }
      else
      { 
         //..TODO add ui logic to door open
      }
   }

   private void OnTriggerExit(Collider other)
   {
      if (allKetCollected?.Invoke(PlayerInventory.singleton.CurrentKeyCount) ?? false)
      {
         GameEvents.gameEvents.DoorTriggerExit();
      }
   }
}
