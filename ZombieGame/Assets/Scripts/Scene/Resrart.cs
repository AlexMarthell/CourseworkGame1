using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Resrart : MonoBehaviour
{
    public Text score;
    public ScoreManager sm;
    void Start()
    {
        score.text = ("Ваш счкет:") + sm.score.ToString();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
