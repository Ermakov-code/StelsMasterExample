using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLogicForKeys : MonoBehaviour
{
   [SerializeField] private ParticleSystem _particleSystemForKeys;
   public static ParticleLogicForKeys particleSystem;


   private void Awake()
   {
      if (particleSystem == null)
      {
         particleSystem = this;
      }
   }
   

   public void PlayParticle(Transform keyPos)
   {
      ParticleSystem particleSystem = Instantiate(_particleSystemForKeys, keyPos.position, Quaternion.identity);
      particleSystem.Play();
   }
   
}
