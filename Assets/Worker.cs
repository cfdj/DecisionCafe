﻿using System.Collections;
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
    public int Energy;
    public int Happiness;
    private int maxEnergy = 100;
    private int maxHappiness = 10;
}
