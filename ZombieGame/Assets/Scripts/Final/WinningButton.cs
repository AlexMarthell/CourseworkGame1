using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningButton : MonoBehaviour
{
    public GameObject panel;
    public GameObject redButton;
    public void OnButtonClick()
    {
        panel.SetActive(true);
        Destroy(redButton);
    }
    
}
