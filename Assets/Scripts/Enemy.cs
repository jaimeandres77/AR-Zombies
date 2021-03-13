using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float stoppingDistance;
    [SerializeField] float damage;

    float lastAttackTime;
    //Seconds that zombie should wait before it attacks again
    float attackCoolDown;

    NavMeshAgent agent;

    GameObject target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
        lastAttackTime = 0;
        attackCoolDown = 2;
        damage = 10;
        stoppingDistance = 2.5f;
    
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist < stoppingDistance)
        {
            stopEnemy();
            attack();
            
        }
        else
        {
            goToTarget();
        }
    }

    private void goToTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }

    private void stopEnemy()
    {
        agent.isStopped = true;
    }

    private void attack()
    {
        if (Time.time - lastAttackTime >= attackCoolDown)
        {
            lastAttackTime = Time.time;
            target.GetComponent<CharacterStats>().takeDamage(damage);
            target.GetComponent<CharacterStats>().checkHealth();
        }
    }
}
