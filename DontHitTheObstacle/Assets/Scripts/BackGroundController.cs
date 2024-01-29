using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour

{
    public float backgroundSpeed ; 
    public float resetYPosition ;
    

    void Update()
    {
       
        transform.Translate(Vector3.up * Time.deltaTime * backgroundSpeed);

        
        if (transform.position.y > resetYPosition)
        {
            ResetBackgroundPosition();
        }
    }

    void ResetBackgroundPosition()
    {
        
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }
}

