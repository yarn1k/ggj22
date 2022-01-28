using UnityEngine;
using NodeCanvas.DialogueTrees;

public class DialogueT : MonoBehaviour
{

    [SerializeField] private DialogueTreeController dialogue;

    void OnTriggerEnter(Collider other) {
        Debug.Log("!");
        if (other.tag == "player") {
            Debug.Log("=)");
            dialogue.StartDialogue();
        }
     }
}
