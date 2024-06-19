using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponents : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start(){
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount){
        currentHealth -= damageAmount;
        if(currentHealth <= 0){
            Kill();
        }
    }

    void Kill(){
        Debug.Log("Player Mati");
    }
}
