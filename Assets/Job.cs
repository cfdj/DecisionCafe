using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newJob",menuName ="Job")]
public class Job : ScriptableObject
{
    public new string name;
    public int busyness;
    public int busynessChange;
    public int changeHour;
    public bool waiting;
    public int revenue;
    public string description;
    public List<Worker> assigned = new List<Worker>();

    public bool assignedCheck(Worker w)
    {
        return assigned.Contains(w);
    }
    public bool staffed()
    {
        bool isStaffed = false;
        int sumEffort = 0;
        foreach(Worker w in assigned)
        {
            if (!w.onbreak)
            {
                if(w.Good == this)
                {
                    sumEffort += 3;
                }
                else if (w.Bad == this)
                {
                    sumEffort += 1;
                }
                else
                {
                    sumEffort += 2;
                }
            }
        }
        if(sumEffort > busyness)
        {
            isStaffed = true;
        }
        return isStaffed;
    }
    public int currentDifficulty()
    {
        int difficulty = 1;
        int sumEffort = 0;
        foreach (Worker w in assigned)
        {
            if (!w.onbreak)
            {
                if (w.Good == this)
                {
                    sumEffort += 3;
                }
                else if(w.Bad == this)
                {
                    sumEffort += 1;
                }
                else
                {
                    sumEffort += 2;
                }
            }
        }
        difficulty = busyness - sumEffort;
        if (difficulty <= 0)
        {
            difficulty = 1;
        }
        return difficulty;
    }
}
