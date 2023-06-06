using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCollider : MonoBehaviour
{

    public Collider Collider;
    public GameObject taskBoard;
    public taskSystem taskSystem;
    public string target;
    public int targetCheck;

    void Start()
    {
        taskSystem = taskBoard.GetComponent<taskSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        target = taskSystem.nowTask;
    }

    void OnTriggerEnter(Collider other)
    {
        print(taskSystem.nowTask);
        
        if(other.tag == taskSystem.nowTask)
        {
            targetCheck = 1;
            print(targetCheck);
        }
    }

    void OnTriggerExit(Collider other)
    {
        targetCheck = 0;
    }
}
