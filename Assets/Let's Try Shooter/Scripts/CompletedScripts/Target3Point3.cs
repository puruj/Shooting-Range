using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target3Point3 : MonoBehaviour {
    //The box's current health point total
    public int currentHealth = 3;

    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;
        Debug.Log("Target 3: 3-points at " + Time.time + " s");

        //Check if health has fallen below zero
        if (currentHealth <= 0)
        {
            //if health has fallen below zero, deactivate it 
            gameObject.SetActive(false);
        }
    }
}
