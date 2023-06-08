using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskSystem : MonoBehaviour
{
    // Start is called before the first frame update
    
    public string nowTask;
    string[] taskArray = new string [5];
    
    void Start()
    {
        taskArray[0] = "Floater";
        taskArray[1] = "Baby Floater";
        taskArray[2] = "Ashling";
        taskArray[3] = "Folinator";
        taskArray[4] = "Luscus Viator";
        taskArray[5] = "Folinator Queen";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
