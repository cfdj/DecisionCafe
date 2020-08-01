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
    public List<Image> icons1;
    public List<Image> icons2;
    public List<Image> icons3;
    public List<Image> icons4;
    private List<List<Image>> icons;
    //worker display variables, sent to the worker display;
    public Text nameDisplay;
    public Text likesDisplay;
    public Text dislikesDisplay;
    public Text goodDisplay;
    public Text badDisplay;

    public Canvas hour;


    public Canvas endScreen;

    private int workerNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Job j in jobs)
        {
            j.assigned = new List<Worker>();
        }
        icons = new List<List<Image>>();
        icons.Add(icons1);
        icons.Add(icons2);
        icons.Add(icons3);
        icons.Add(icons4);
        display.nameDisplay = nameDisplay;
        display.likesDisplay = likesDisplay;
        display.dislikesDisplay = dislikesDisplay;
        display.goodDisplay = goodDisplay;
        display.badDisplay = badDisplay;
        setJobDisplay(job1, 0);
        setJobDisplay(job2, 1);
        setJobDisplay(job3, 2);
        setJobDisplay(job4, 3);
        Assign();
    }
    void Assign()
    {
        if (workerNum < workers.Count)
        {
            display.SetWorker(workers[workerNum]);
        }
        else
        {
            Hour();
        }
    }
    void setJobDisplay(Button job, int jobnum)
    {
        List<Text> texts = new List<Text>();
        texts.AddRange(job.GetComponentsInChildren<Text>());
        foreach(Text t in texts)
        {
            if (t.CompareTag("Name"))
            {
                t.text = jobs[jobnum].name;
            }
            else
            {
                t.text = jobs[jobnum].description;
            }
        }
    }
    public void jobSelect(Job j)
    {
        if (j.assigned.Count < 4)
        {
            j.assigned.Add(workers[workerNum]);
            int index = jobs.IndexOf(j);
            Debug.Log("Job num: " + index + " Assign num: " + j.assigned.Count);
            icons[index][j.assigned.Count - 1].gameObject.SetActive(true);
            workerNum += 1;
            Assign();
        }
    }

    void Hour()
    {
        display.gameObject.SetActive(false);
        allocation.gameObject.SetActive(false);
        hour.gameObject.SetActive(true);

    }
}
