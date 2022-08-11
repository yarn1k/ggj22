using UnityEngine;
using NodeCanvas.Framework;
 
public class LockWalk : ActionTask{
 
	protected override void OnExecute(){
        Cursor.lockState = CursorLockMode.None;
		EndAction(true);
	}
}