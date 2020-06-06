using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform igrac;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
		igrac = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = igrac.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
		nav.SetDestination (igrac.position);
        }
        else
        {
           nav.enabled = false;
        }
    }
}
