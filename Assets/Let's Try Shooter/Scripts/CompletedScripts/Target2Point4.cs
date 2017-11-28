using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2Point4 : MonoBehaviour {
    public int currentHealth = 3;
    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;
        Debug.Log("Target 2: 4-points at " + Time.time + " s");

        //Check if health has fallen below zero
        if (currentHealth <= 0)
        {
            //if health has fallen below zero, deactivate it 
            gameObject.SetActive(false);
        }
    }
}
