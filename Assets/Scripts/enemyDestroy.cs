using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject control;
    public GameObject self;
    public DayNight dayNight;

    void Start()
    {
        dayNight = control.GetComponent<DayNight>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dayNight.currentTime >= 1)
        {
            Object.Destroy(self);
        }
    }
}
