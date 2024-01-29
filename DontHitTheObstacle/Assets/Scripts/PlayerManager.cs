using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Transform floatingText;
    public Slider slider;
    public float health = 100f;
    bool dead=false;
    public GameObject restartB;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("engel"))
        {
            float damage = 20f;
            GetDamage(damage);
        }
    }
    public void GetDamage(float damage)
    {
        Instantiate(floatingText, transform.position, Quaternion.identity).GetComponent<TextMesh>().text = damage.ToString();
        if (health - damage>0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        slider.value = health;
        amIDead();
    }
    public  void amIDead()
    {
        if (health<=0)
        {
            dead = true;
            Destroy(gameObject);
            Time.timeScale = 0;
            restartB.SetActive(true);  
        }
    }
}
