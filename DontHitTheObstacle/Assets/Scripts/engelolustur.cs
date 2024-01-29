using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelolustur : MonoBehaviour
{
    public GameObject Platform1;
    public float baseSpeed ;
    public float currentSpeed;
    public int scoreThershold;
    public float speedIncreaseInterval = 5f; 
    public float timeSinceLastSpeedIncrease;

    void Start()
    {
        currentSpeed = baseSpeed;
        InvokeRepeating("zeminolustur", 2f, 1f);
    }

    void Update()
    {
        ScoreManager scoremanager = FindObjectOfType<ScoreManager>();
        if (scoremanager.Score >= scoreThershold)
        {
            scoreThershold += 40;
            currentSpeed += 2f; 
        }
        timeSinceLastSpeedIncrease += Time.deltaTime;
        if (timeSinceLastSpeedIncrease >= speedIncreaseInterval)
        {
            timeSinceLastSpeedIncrease = 0f;
            currentSpeed += 0.1f;
        }
    }

    void zeminolustur()
    {
        Instantiate(Platform1, new Vector2(Random.Range(-2, +3), Random.Range(4, 5)), Quaternion.identity)
            .GetComponent<Rigidbody2D>().velocity = new Vector2(0, -currentSpeed);
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
}
