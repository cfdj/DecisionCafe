using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourControl : MonoBehaviour
{
    public Canvas canvas;
    public Text profitDisplay;
    public List<workerUI> workerUIs;
    public List<Job> jobs;
    public int revenueTotal;
    public int wages;
    public int profits;
    public void BreakSelected(Worker w)
    {
        int difficulty = 0;
        foreach(workerUI wui in workerUIs)
        {
            difficulty = wui.worker.assigned.currentDifficulty();
            wui.hourUpdate(difficulty);
        }
        foreach (Job j in jobs)
        {
            if (j.staffed())
            {
                revenueTotal += j.revenue;
            }
            else
            {
                if (j.assigned.Count > 0) //checking someone is actually doing the job
                {
                    revenueTotal += j.revenue / 2;
                }
            }
        }
    }
}
