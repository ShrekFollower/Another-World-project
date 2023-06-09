using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    
    public int currentTime = 0;
    public GameObject Camera;
    public photoTaken PhotoTaken;
    
    // Start is called before the first frame update
    void Start()
    {
        PhotoTaken = Camera.GetComponent<photoTaken>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(PhotoTaken.nextTask >= 3)
        {
            currentTime = 1;
        }
    }
}
