using UnityEngine;
using NodeCanvas.Framework;
 
public class EndDialogue : ActionTask{
 
	protected override void OnExecute(){
        Cursor.lockState = CursorLockMode.Locked;
		EndAction(true);
	}
}