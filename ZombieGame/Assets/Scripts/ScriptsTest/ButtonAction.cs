using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonAction : MonoBehaviour
{
    public void ChangeSceneOnClick()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("TestScene");
    }
}