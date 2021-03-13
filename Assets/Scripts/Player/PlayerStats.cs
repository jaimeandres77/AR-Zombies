using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    // Start is called before the first frame update

    PlayerUI playerUI;
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        

        maxStamina = 100;
        currentStamina = maxStamina;

        playerUI = GetComponent<PlayerUI>();

        setStats();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Die()
    {
        Debug.Log("You died");
    }

    void setStats()
    {
        playerUI.healthAmount.text = currentHealth.ToString();
        playerUI.staminaAmount.text = currentStamina.ToString();
    }

    public override void checkHealth()
    {
        base.checkHealth();
        setStats();
    }

    public override void checkStamina()
    {
        base.checkStamina();
        setStats();
    }
}
