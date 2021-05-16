using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
   [SerializeField] private int keysToPass;
   
   public static GameEvents gameEvents = null;

   public event Action OnDoorTriggerEnter;

   private void OnEnable()
   {
      TriggerEvent.allKetCollected += IsAllKeyCollected;
   }

   private void OnDisable()
   {
      TriggerEvent.allKetCollected -= IsAllKeyCollected;
   }


   private void Awake()
   {
      if (gameEvents == null)
      {
         gameEvents = this;
      }
   }

   private bool IsAllKeyCollected(int keys)
   {
      return keysToPass <= keys;
   }

   public int KeyToCollect()
   {
      return keysToPass;
   }

   public void DoorTriggerEnter()
   {
      OnDoorTriggerEnter?.Invoke();
   }
   
}
