using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtoinScene1 : MonoBehaviour
{

    public void ChangeSceneOnClick()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
