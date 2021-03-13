using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public float currentHealth;
    public float maxHealth;
    
    public float currentStamina;
    public float maxStamina;

    public bool isDead;

    void Start()
    {
        isDead = false;
    }

    public virtual void checkHealth()
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            Die();
        }
    }

    public virtual void checkStamina()
    {
        if (currentStamina >= maxStamina)
        {
            currentStamina = maxStamina;
        }
        if (currentStamina <= 0)
        {
            currentStamina = 0;
        }
    }

    public virtual void Die()
    {
        //Override
    }
    
    public void takeDamage(float damage)
    {
        currentHealth -= damage;

    }


}
