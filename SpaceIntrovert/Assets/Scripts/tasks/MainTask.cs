using UnityEngine;
using NodeCanvas.Framework;

public class MainTask : ActionTask
{

    public BBParameter<ReactorDoor> door;

    protected override void OnExecute()
    {
        door.value.PasswordReset();
        EndAction(true);
    }
}