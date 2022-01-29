using UnityEngine;
using UnityEngine.UI;

public class StressBar : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private int stress = 5;
    void Start()
    {
        // Debug.Log(Manager.Instance.stress);
    }

    public void UpdateStress()
    {
        text.text = stress.ToString() + "/5";
    }

    public int GetStress()
    {
        return stress;
    }

    public void AddStress(int count)
    {
        stress += count;
    }
}
