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
}
