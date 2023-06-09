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
        taskArray[0] = "Folinator Queen";
        taskArray[1] = "Folinator";
        taskArray[2] = "Ashling";
        taskArray[3] = "Floater";
        taskArray[4] = "Baby Floater";
        taskArray[5] = "Luscus Viator";

        taskHint[0] = "Found near the Big Tree";
        taskHint[1] = "Found near bundles of sticks (near the queens nest)";
        taskHint[2] = "Found alone near rocks";
        taskHint[3] = "Found near the highest mountain peak";
        taskHint[4] = "Found near the adult floaters";
        taskHint[5] = "Found in big open areas";
        nowTask = "Floater";

        PhotoTaken = Camera.GetComponent<photoTaken>();
    }

    void Update()
    {
        nowTask = taskArray[PhotoTaken.nextTask];
        name.text = taskArray[PhotoTaken.nextTask];
        hint.text = taskHint[PhotoTaken.nextTask];
    }
}
