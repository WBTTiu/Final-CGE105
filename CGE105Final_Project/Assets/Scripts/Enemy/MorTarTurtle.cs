using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaorTarTurtle : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    float firerate;
    float nextfire;
    // Start is called before the first frame update
    void Start()
    {
        firerate = 1f;
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToTimeFire();
    }

    void CheckIfTimeToTimeFire()
    {
        if (Time.time > nextfire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextfire = Time.time + firerate;
        }

    }
}
