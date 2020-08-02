using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jobUI : MonoBehaviour
{
    [SerializeField] Text Jname;
    [SerializeField] Text difficulty;
    [SerializeField] Text assigned;
    public Job job;
    public void updateDisplay()
    {
        Jname.text = job.name;
        difficulty.text = "Busyness: " + job.busyness;
        assigned.text = "People working: ";
        foreach(Worker w in job.assigned)
        {
            assigned.text += w.name + ", ";
        }
    }
}
