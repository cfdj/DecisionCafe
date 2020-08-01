using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class workerUI : MonoBehaviour
{
    [SerializeField] int energyRecovery;
    [SerializeField] int happinessRecovery;
    public Worker worker;
    public Text nameDisplay;
    public Text energyDisplay;
    public Text happyDisplay;
    public Button breakButton;
    public HourControl hourControl;

    public void onBreak()
    {
        worker.Energy += energyRecovery;
        worker.Happiness += happinessRecovery;
        hourControl.BreakSelected(worker);
    }
}
