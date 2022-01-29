using NodeCanvas.DialogueTrees;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorRepair : MonoBehaviour
{
    public DialogueTreeController dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hammer")
        {
                dialogue.StartDialogue();
        }
    }
}
