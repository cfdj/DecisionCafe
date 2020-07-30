using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] List<Worker> workers;
    [SerializeField] List<Job> jobs;


    public Canvas allocation;
    public Button job1;
    public Button job2;
    public Button job3;
    public Button job4;

    public Canvas hour;


    public Canvas endScreen;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Hour()
    {

    }
}
