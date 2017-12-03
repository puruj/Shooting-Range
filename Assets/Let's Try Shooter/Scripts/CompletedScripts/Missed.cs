using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Missed : MonoBehaviour {

    private PrinttoText printToText;



    //The box's current health point total
    public int currentHealth = 3;

    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        Debug.Log("Missed all targets at " + Time.time + " s");

        //Check if health has fallen below zero
        if (currentHealth <= 0)
        {
            //if health has fallen below zero, deactivate it 
            gameObject.SetActive(false);
        }
    }
}
