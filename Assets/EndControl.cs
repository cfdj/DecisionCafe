using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndControl : MonoBehaviour
{
    [SerializeField] Job off;
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
