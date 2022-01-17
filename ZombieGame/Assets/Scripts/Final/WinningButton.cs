using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningButton : MonoBehaviour
{
    
    public GameObject redButton;
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnButtonClick()
    {
        anim.SetTrigger("DDoorBroked");
        Destroy(redButton);
    }
    
}
