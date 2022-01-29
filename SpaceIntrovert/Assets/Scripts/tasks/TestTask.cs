using UnityEngine;
using NodeCanvas.Framework;
 
public class TestTask : ActionTask{

    public BBParameter<StressBar> stress;
    public int stressCount = 1;
 
	protected override void OnExecute(){
		Debug.Log("My agent is " + agent.name);
        stress.value.AddStress(stressCount);
        stress.value.UpdateStress();
        Debug.Log(stress.value);
		EndAction(true);
	}
}