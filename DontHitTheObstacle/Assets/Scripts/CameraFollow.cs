using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maxHiz;
    bool hareket = true;
    
    void Start()
    {
        hiz = 0.5f;
        hizlanma = 0.005f;
        maxHiz = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (hareket)
        {
            //KameraHareket();
        }
        
    }
    void KameraHareket()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if (hiz > maxHiz)
       {
            hiz = maxHiz;
        }
    }
    
}
