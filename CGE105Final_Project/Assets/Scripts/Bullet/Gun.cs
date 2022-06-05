using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] float GSpeed;

    public int Damage = 90;
    Rigidbody2D GRb;
    public GameObject ImpactEffect;
    // Start is called before the first frame update
    void Start()
    {
        GRb = GetComponent<Rigidbody2D>();
        if (transform.localRotation.z > 0)
        {
            GRb.AddForce(new Vector2(-1, 0) * GSpeed, ForceMode2D.Impulse);
        }
        else
        {
            GRb.AddForce(new Vector2(1, 0) * GSpeed, ForceMode2D.Impulse);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void removeForce()
    {
        GRb.velocity = new Vector2(0, 0);
    }

    //Destroy
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        MorHealth Mor  = hitInfo.GetComponent<MorHealth>();
        Enemy enemy =hitInfo.GetComponent<Enemy>();
        DropItem DropBPEnemy = hitInfo.GetComponent<DropItem>();
        BP2 DropBP2Enemy = hitInfo.GetComponent<BP2>();
        BP3 DropBP3Enemy = hitInfo.GetComponent<BP3>();
        if (enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
        else if (Mor != null)
        {
            Mor.TakeDamage(Damage);
        }else if (DropBPEnemy != null)
        {
            DropBPEnemy.TakeDamage(Damage);
        }
        else if (DropBP2Enemy != null)
        {
            DropBP2Enemy.TakeDamage(Damage);
        }
        else if (DropBP3Enemy != null)
        {
            DropBP3Enemy.TakeDamage(Damage);
        }


        Instantiate(ImpactEffect, transform.position, transform.rotation);
        Destroy(gameObject);


    }

}
