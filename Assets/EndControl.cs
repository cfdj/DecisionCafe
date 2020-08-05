using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndControl : MonoBehaviour
{
    [SerializeField] Job off;
    public List<Text> hDisplays;
    public List<Worker> workers;
    public Canvas canvas;
    public Text revenueDisplay;
    public Text wagesDisplay;
    public Text profitDisplay;
    public Text happinessDisplay;
    int profit;
    int happiness;
    int revenueTotal;
    int wageTotal;

    public void End(int revenue, int wages)
    {
        int numWorking = 0;
        foreach (Worker w in workers)
        {
            if (w.assigned != off)
            {
                numWorking += 1;
                happiness += w.Happiness;
            }
        }
        Worker c;
        for(int i = 0; i < workers.Count; i++)
        {
            c = workers[i];
            if (c.assigned != off)
            {
                hDisplays[i].text = c.name + ": +" + c.Happiness;
            }
            else
            {
                hDisplays[i].text = c.name + ": Not in work";
            }
        }
        wageTotal = wages*numWorking;
        revenueTotal = revenue;
        profit = revenue - wages * numWorking;
        updateDisplay();
    }

    public void updateDisplay()
    {
        wagesDisplay.text = "Wages: " + wageTotal;
        revenueDisplay.text = "Total Revenue: " +revenueTotal;
        profitDisplay.text = "Profits: " + profit;
        happinessDisplay.text = "Happiness: " + happiness;
    }
}
