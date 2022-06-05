using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float movespeed = 7f;
    Rigidbody2D EBRb;
    PlayerController target;
    Vector2 moveDirection;
    public GameObject BulletEffect;

    public int Damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        EBRb = GetComponent<Rigidbody2D>();
        target = FindObjectOfType<PlayerController>();
        moveDirection = (target.transform.position - transform.position).normalized * movespeed;
        EBRb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject,3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Character"))
        {
            Instantiate(BulletEffect, transform.position, transform.rotation);
            HealthManager.health -= 1;
            Destroy(gameObject);
            
        }
    

        if (collision.tag == "Platform" )
        {
            Instantiate(BulletEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
        if (collision.tag == "Player")
        {
            Instantiate(BulletEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
       
    }
    
}
