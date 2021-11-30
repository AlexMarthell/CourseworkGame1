using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject terminal;
    [SerializeField] GameObject btn;
    [SerializeField] GameObject greenWindow;
   
    
    public void OnClick()
    {
        greenWindow.SetActive(true);
        //greenWindow.transform.position = player.transform.position;
        //Debug.Log(greenWindow.transform.position);

    }
    
    void Start()
    {
        Debug.Log(terminal.transform.position.x);
        btn.SetActive(false);
    }


    void Update()
    {
        if (player.transform.position.x >= terminal.transform.position.x - 5
            && player.transform.position.x <= terminal.transform.position.x + 1)
        {
            btn.SetActive(true);

        }
        else
        {
            btn.SetActive(false);
        }
        //Debug.Log(greenWindow.transform.position);
    }

}
