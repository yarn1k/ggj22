using UnityEngine;
using NodeCanvas.DialogueTrees;

public class DialogueT : MonoBehaviour
{

    [SerializeField] private DialogueTreeController dialogue;
    // [SerializeField] private ;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "player") {
            Cursor.lockState = CursorLockMode.None;
            dialogue.StartDialogue();
        }
     }
}
