using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSystem : MonoBehaviour
{
    //[SerializeField] GameObject player;
    [SerializeField] GameObject terminal;
    [SerializeField] GameObject btn;
    
    private PlayerController player;


    public void OnClick()
    {
       
        //greenWindow.transform.position = player.transform.position;
        //Debug.Log(greenWindow.transform.position);

    }
    
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        //Debug.Log(terminal.transform.position.x);
        btn.SetActive(false);
    }


    void Update()
    {
        if (player.health > 0)
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
        }
           
        else
        {
            btn.SetActive(false);
        }
        //Debug.Log(greenWindow.transform.position);
    }

}
