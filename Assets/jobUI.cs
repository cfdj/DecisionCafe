using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jobUI : MonoBehaviour
{
    [SerializeField] Text Jname;
    [SerializeField] Text difficulty;
    [SerializeField] Text changeTime;
    [SerializeField] Text assigned;
    public Job job;
    public void updateDisplay()
    {
        Jname.text = job.name;
        difficulty.text = "Busyness: " + job.busyness;
        if (job.busynessChange < job.busyness)
        {
            changeTime.text = "Gets less busy at: " + job.changeHour +":00";
        } else if (job.busynessChange == job.busyness) {
            changeTime.text = "Will stay this busy";
        } else
        {
            changeTime.text = "Gets busier at: " + job.changeHour + ":00";
        }
        assigned.text = "People working: ";
        foreach(Worker w in job.assigned)
        {
            assigned.text += w.name + ", ";
        }
    }
}
