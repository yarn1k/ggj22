using NodeCanvas.DialogueTrees;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorDoor : MonoBehaviour
{
    public GameObject chip;
    public Animator door;
    private bool isPasswordRight = false;
    public DialogueTreeController dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            if (isPasswordRight)
            {
                chip.SetActive(false);
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
        chip.SetActive(true);
    }
}
