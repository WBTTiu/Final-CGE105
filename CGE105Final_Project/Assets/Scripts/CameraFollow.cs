using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    public Transform target;
    public float smoothing;
    //public Vector3 offset;
    //public Vector3 minValues,maxValues;

    Vector3 offset;
    float lowY;
     //Start is called before the first frame update
    void Start()
    {
        offset = transform.position-target.position;
        lowY=transform.position.y;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position+offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing*Time.deltaTime);
        if(transform.position.y < lowY)
        {
            transform.position = new Vector3(transform.position.x,lowY,transform.position.z);
        }

        //Follow();

    }

    /*void Follow()
    {

        Vector3 targetPosition = target.position + offset;
        Vector3 boundPosition = new Vector3(Mathf.Clamp(targetPosition.x, minValues.x, maxValues.x),
                                            Mathf.Clamp(targetPosition.y, minValues.y, maxValues.y),
                                            Mathf.Clamp(targetPosition.z, minValues.z, maxValues.z));
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothing*Time.deltaTime);
        transform.position = smoothPosition;
    }*/
}
