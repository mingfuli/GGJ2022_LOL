using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
   public static int balance = 2000;
   public static int reputation = 100;

   public static Apartment[] apartments;
   public static Renter[] renters;


   public static void updateMonthlyBalance() {
       for (int i = 0; i < apartments.Length; i++) {
           balance += apartments.rent;
       }
   }

   public static void updateMonthlyHappiness() {
       int temp = 0;
       for (int i = 0; i < renters.Length; i++) {
           temp += renters.happiness;
       }

       
       reputation = temp/renters.Length > 0 ? temp/renters.Length : 0; 
   }
}