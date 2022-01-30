using UnityEngine;
using NodeCanvas.Framework;

public class MusicTask : ActionTask
{

    public BBParameter<Music> music;

    protected override void OnExecute()
    {
        music.value.ChangeMusic();
        EndAction(true);
    }
}