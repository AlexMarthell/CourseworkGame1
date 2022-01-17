using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSystem : MonoBehaviour
{
    
    [SerializeField] GameObject terminal;
    [SerializeField] GameObject btn;
    
    private PlayerController player;


   
    
    void Start()
    {
        btn.SetActive(false);
        player = FindObjectOfType<PlayerController>();
       
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
           
        //else
        //{
        //    btn.SetActive(false);
        //}
        
    }

}
