﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      GameEvents.gameEvents.DoorTriggerEnter();
   }
}
