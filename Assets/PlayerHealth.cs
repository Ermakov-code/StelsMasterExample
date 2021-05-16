using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   [SerializeField] private int maxHealth;
   [SerializeField] private int currentHealth;

   public Image[] hearts;
   public Sprite fullHealth;
   public Sprite emptyHeart;

   private void Start()
   {
      currentHealth = maxHealth;
   }

   private void OnEnable()
   {
      AttackPlayer.OnPlayerTakeDamage += TakeDamage;
   }

   private void OnDisable()
   {
      AttackPlayer.OnPlayerTakeDamage -= TakeDamage;
   }

   public void TakeDamage(int damage)
   {
      if (damage < currentHealth)
      {
         currentHealth -= damage;
      }
      else
      {
         DieEvent();
      }
   }

   private void DieEvent()
   {
      //..TODO add ui logic to die
   }

   private void Update()
   {
      for (int i = 0; i < hearts.Length; i++)
      {

         if (i < currentHealth)
         {
            hearts[i].sprite = fullHealth;
         }
         else
         {
            hearts[i].sprite = emptyHeart;
         }
         if (i < maxHealth)
         {
            hearts[i].enabled = true;
         }
         else
         {
            hearts[i].enabled = false;
         }
      }
   }
}
