using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            startAnim.SetBool("StartOpen", true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        startAnim.SetBool("StartOpen", false);
        dm.EndDialogue();
    }
}
