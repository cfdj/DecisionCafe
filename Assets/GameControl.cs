using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] List<Worker> workers;
    [SerializeField] List<Job> jobs;
    [SerializeField] workerDisplay display;

    public Canvas allocation;
    public Button job1;
    public Button job2;
    public Button job3;
    public Button job4;
    //worker display variables, sent to the worker display;
    public Text nameDisplay;
    public Text likesDisplay;
    public Text dislikesDisplay;
    public Text goodDisplay;
    public Text badDisplay;

    public Canvas hour;


    public Canvas endScreen;



    // Start is called before the first frame update
    void Start()
    {
        int workerNum = 0;
        Assign(workerNum);
    }
    void Assign(int workerNum)
    {
        if (workerNum < workers.Count)
        {
            display.SetWorker(workers[workerNum]);
        }
    }
    public void jobSelect(Job j)
    {

    }

    void Hour()
    {

    }
}
