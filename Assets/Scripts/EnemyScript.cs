using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyHealth = 60f;

    public float playerRange = 10f;

    public Rigidbody enemyRigidbody;

    public float moveSpeed;

    public GameObject playerLocation;

    void Update()
    {
      if (Vector3.Distance(transform.position, playerLocation.transform.position) < playerRange)
        {
            Vector3 playerDirection = playerLocation.transform.position - transform.position;

            enemyRigidbody.velocity = playerDirection.normalized * moveSpeed;
        }
        else
        {
            enemyRigidbody.velocity = Vector3.zero;
        }
    }

    public void TakeDamage(float amount)
    {
        enemyHealth -= amount;
        
        if (enemyHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }

    public void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStats.playerHealth -= 5;
        }
    }
}
