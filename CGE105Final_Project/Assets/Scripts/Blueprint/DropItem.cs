using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{

    public GameObject Blueprint1;
   
    


    public int health = 90;
    public GameObject deathEffect;
    // Start is called before the first frame update
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
        Instantiate(Blueprint1, position, Quaternion.identity);
        Blueprint1.SetActive(true);
    }

}
