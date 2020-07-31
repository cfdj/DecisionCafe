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
        nameDisplay.text ="Name: "+ worker.name;
        likesDisplay.text = "Likes: " + worker.Likes.name;
        dislikesDisplay.text = "Dislikes: " + worker.Dislikes.name;
        goodDisplay.text = "Good at: " + worker.Good.name;
        badDisplay.text = "Bad at: " + worker.Bad.name;
    }
}
