using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject Platform2;
    public float baseSpeed2 ;
    public float currentSpeed2;
    public int scoreThershold2;
    public float speedIncreaseInterval2 = 5f;
    public float timeSinceLastSpeedIncrease2;
   
    

    void Start()
    {
        currentSpeed2 = baseSpeed2;
        InvokeRepeating("zeminolustur2", 1f, 0.9f);


    }

    void Update()
    {
        

        ScoreManager scoremanager = FindObjectOfType<ScoreManager>();
        if (scoremanager.Score >= scoreThershold2)
        {
            scoreThershold2 += 50;
            currentSpeed2 += 2f;
        }
        timeSinceLastSpeedIncrease2 += Time.deltaTime;
        if (timeSinceLastSpeedIncrease2 >= speedIncreaseInterval2)
        {
            timeSinceLastSpeedIncrease2 = 0f;
            currentSpeed2 += 0.5f;
        }
        

    }

    void zeminolustur2()
    {
        Instantiate(Platform2, new Vector2(Random.Range(-2, +3), Random.Range(4, 5)), Quaternion.identity)
            .GetComponent<Rigidbody2D>().velocity = new Vector2(0, -currentSpeed2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
            ScoreManager scoremanager = FindObjectOfType<ScoreManager>();
            if (scoremanager != null)
            {
                scoremanager.scoreArttýr(10);
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager scoremanager = FindObjectOfType<ScoreManager>();
            if (scoremanager != null)
            {
                scoremanager.scoreArttýr(-10);
            }
            
        }
        
    }
    //void olusturmaSýklýgý()
    //{

    //    if (currentSpeed2 >= 5 && currentSpeed2 <= 7)
    //    {
           
    //        InvokeRepeating("zeminolustur2", 1f, 1f);
    //    }
    //    else if (currentSpeed2 >= 7 && currentSpeed2 <= 10)
    //    {
           
    //        InvokeRepeating("zeminolustur2", 1f, 0.8f);
    //    }
    //    else if (currentSpeed2 >= 10 )
    //    {
            
    //        InvokeRepeating("zeminolustur2", 1f, 0.5f);
    //    }
    //}
}
