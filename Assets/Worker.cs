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
    public int Energy;
    public int Happiness;
    public bool onbreak = false;
    public readonly int maxEnergy = 10;
    public readonly int maxHappiness = 10;

    public void Reset(int e, int h)
    {
        Energy = e;
        Happiness = h;
        onbreak = false;
    }
}
