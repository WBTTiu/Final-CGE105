using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BP2 : MonoBehaviour
{
    public GameObject Blueprint2;




    public int health = 90;
    public GameObject deathEffect;
    
    private void Start()
    {

    }


    public void TakeDamage(int Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            Die();
        }
    }



    void Die()
    {

        Destroy(gameObject);
        DropBP();

    }

    void DropBP()
    {
        Vector3 position = transform.position;
        Instantiate(Blueprint2, position, Quaternion.identity);
        Blueprint2.SetActive(true);
    }
}
