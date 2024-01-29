using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void RestartGame()
    {
        SceneManager.LoadScene(0); 
    }
}
