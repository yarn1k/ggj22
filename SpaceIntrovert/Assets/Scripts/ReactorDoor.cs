using NodeCanvas.DialogueTrees;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorDoor : MonoBehaviour
{
    public Animator door;
    public static bool isPasswordRight = false;
    public DialogueTreeController dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            if (isPasswordRight)
            {
                door.SetBool("character_nearby", true);
            } 
            else
            {
                dialogue.StartDialogue();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetBool("character_nearby", false);
    }

    public void PasswordReset()
    {
        isPasswordRight = true;
    }
}
