using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    

    private PlayerController player;
   

    public void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }


    private void Update()
    {


    }
   
    public void OnKeyRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        Time.timeScale = 1;
    }
    public void OnKeyStop()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}

