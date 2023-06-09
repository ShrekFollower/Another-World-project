using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class taskSystem : MonoBehaviour
{
    
    public string nowTask;
    string[] taskArray = new string [6];
    public GameObject Camera;
    public photoTaken PhotoTaken;
    public TMP_Text hint;
    public TMP_Text name;
    string[] taskHint = new string [6];
    
    void Start()
    {
        taskArray[0] = "Floater";
        taskArray[1] = "Baby Floater";
        taskArray[2] = "Ashling";
        taskArray[3] = "Folinator";
        taskArray[4] = "Luscus Viator";
        taskArray[5] = "Folinator Queen";

        taskHint[0] = "Found near the bottom of trees";
        taskHint[1] = "Found near adult Floaters";
        taskHint[2] = "Found alone near rocks";
        taskHint[3] = "Found near piles of sticks";
        taskHint[4] = "Luscus Viator";
        taskHint[5] = "Folinator Queen";
        nowTask = "Floater";

        PhotoTaken = Camera.GetComponent<photoTaken>();
    }

    void Update()
    {
        nowTask = taskArray[PhotoTaken.nextTask];
        name.text = taskArray[PhotoTaken.nextTask];
    }
}
