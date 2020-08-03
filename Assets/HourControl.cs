using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourControl : MonoBehaviour
{
    public Canvas canvas;
    public Text profitDisplay;
    public Text hourDisplay;
    public Canvas endCanvas;
    public List<workerUI> workerUIs;
    public List<jobUI> jobUIs;
    public List<Job> jobs;
    public int revenueTotal;
    public int wages;
    public int profits;
    int curTime = 9;
    public void BreakSelected()
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
        profitDisplay.text = "Revenue: " + revenueTotal;
        curTime += 1;
        if (curTime > 17)
        {
            end();
        }
        else
        {
            updateDisplay();
        }
    }
    public void end()
    {
        canvas.gameObject.SetActive(false);
        endCanvas.gameObject.SetActive(true);
    }
    public void updateDisplay()
    {
        foreach(workerUI w in workerUIs)
        {
            w.updateDisplay();
        }
        foreach(jobUI j in jobUIs)
        {
            j.updateDisplay();
        }
        hourDisplay.text = "Time: " + curTime + ":00";
    }
}
