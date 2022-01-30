using UnityEngine;
using NodeCanvas.Framework;

public class EndTask : ActionTask
{

    public BBParameter<EndGame> game;

    protected override void OnExecute()
    {
        game.value.SetEndGame();
        EndAction(true);
    }
}