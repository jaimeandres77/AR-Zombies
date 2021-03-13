using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    //Here goes code to give a certain amount of points when a zombie is killed
    private float scoreAddAmount = 10;

    SpawnZombies spawn;

    GameController gameController;

   // public float vida = 50f;



    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        spawn = gameController.GetComponentInChildren<SpawnZombies>();
        

        maxHealth = 100;
        currentHealth = 100;

        maxStamina = 100;
        currentStamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {

            Die();
        }
    }

    public override void Die()
    {

        gameController.AddScore(scoreAddAmount);

        //code to give points when the zombie dies needs to be implemented in this part 
        spawn.enemiesKilled++;
        Destroy(gameObject);
    }
}
