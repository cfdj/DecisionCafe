using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class workerUI : MonoBehaviour
{
    [SerializeField] int energyRecovery;
    [SerializeField] int happinessRecovery;
    [SerializeField] Job off;
    public Worker worker;
    public Text nameDisplay;
    public Text energyDisplay;
    public Text happyDisplay;
    public Slider energyBar;
    public Slider happyBar;
    public Button breakButton;
    public HourControl hourControl;
    public bool onbreak = false;

    public void updateDisplay()
    {
        nameDisplay.text = worker.name;
        energyBar.value = worker.Energy;
        happyBar.value = worker.Happiness;
        if(worker.assigned == off)
        {
            energyBar.gameObject.SetActive(false);
            happyBar.gameObject.SetActive(false);
            happyDisplay.text = "";
            energyDisplay.text = "Has been given the day off";
            breakButton.gameObject.SetActive(false);
        }
    }

    public void hourUpdate(int difficulty) //difficulty has a minimum value of 1
    {
        int happinessFactor = 0;
        if (!onbreak)
        {
            worker.Energy -= difficulty;
            if(worker.Energy < 0)
            {
                worker.Energy = 0;
            }
            //if the worker is tried, reduce happiness
            if (worker.Energy < worker.maxEnergy)
            {
                if(worker.assigned == worker.Likes)
                {
                    happinessFactor = 1;
                }
                worker.Happiness = (worker.Happiness - difficulty) +happinessFactor;
            }
            if(worker.assigned == worker.Dislikes)
            {
                worker.Happiness -= 1;
            }
            if(worker.Happiness < 0)
            {
                worker.Happiness = 0;
            }
        }
        onbreak = false;
        worker.onbreak = false;
        updateDisplay();
    }
    public void onBreak()
    {
        onbreak = true;
        worker.onbreak = true;
        worker.Energy += energyRecovery;
        worker.Happiness += happinessRecovery;
        hourControl.BreakSelected();
    }
}
