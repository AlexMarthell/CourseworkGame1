using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonAction : MonoBehaviour
{
    public void ChangeSceneOnClick()
    {
        SceneManager.LoadScene("TestScene");
    }
}