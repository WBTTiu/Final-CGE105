using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BP : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Character"))
        {
            MissionManager.Blueprint++;
            Destroy(gameObject);
        }
    }
}
