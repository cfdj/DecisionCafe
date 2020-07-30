using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class workerDisplay : MonoBehaviour
{
    public Text nameDisplay;
    public Text likesDisplay;
    public Text dislikesDisplay;
    public Text goodDisplay;
    public Text badDisplay;
    private Worker worker;

    public void SetWorker(Worker w)
    {
        worker = w;
        nameDisplay.text = worker.name;
        likesDisplay.text = worker.Likes.name;
        dislikesDisplay.text = worker.Dislikes.name;
        goodDisplay.text = worker.Good.name;
        badDisplay.text = worker.Bad.name;
    }
}
