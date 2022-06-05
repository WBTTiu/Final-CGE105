using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPlus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.name.Equals("Character"))
        {
            HealthManager.health++;
            Destroy(gameObject);
        }
    }
}
