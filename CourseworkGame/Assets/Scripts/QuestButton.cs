using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestButton : MonoBehaviour
{
    public Animator[] buttons;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach(Animator anim in buttons)
            {
                anim.SetTrigger("IsTriggered");
            }
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Animator anim in buttons)
            {
                anim.SetTrigger("IsTriggered");
            }
        }

    }
}
