using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BP3 : MonoBehaviour
{
    public GameObject Blueprint3;




    public int health = 270;
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
        Instantiate(Blueprint3, position, Quaternion.identity);
        Blueprint3.SetActive(true);
    }
}
