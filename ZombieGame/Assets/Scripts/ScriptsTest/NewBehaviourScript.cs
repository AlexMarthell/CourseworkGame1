using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public Text txt;

    private void Start()
    {
        txt.color = Color.white;
        txt.text = "DenisPIpka";
    }
}
