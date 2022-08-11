using UnityEngine;
using NodeCanvas.Framework;

public class StressDialogue : MonoBehaviour
{
    [SerializeField] private StressBar _stressBar;
    public StressBar stressBar{
		get {return _stressBar;}
		set {_stressBar = value;}
	}

    private GlobalBlackboard blackboard;
    private int _stress;

    public int stress{
		get {return _stress;}
		set {_stress = value;}
	}

    private void Start()
    {
        blackboard = GetComponent<GlobalBlackboard>();
        _stress = stressBar.GetStress();
    }

    private void FixedUpdate()
    {
       
    }
    
}
