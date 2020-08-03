using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newWork",menuName ="Worker")]
public class Worker : ScriptableObject
{
    public new string name;
    public Job Likes;
    public Job Dislikes;
    public Job Good;
    public Job Bad;
    public Job assigned;
    public int Energy =100;
    public int Happiness = 5;
    public bool onbreak = false;
    public readonly int maxEnergy = 100;
    public readonly int maxHappiness = 10;
}
