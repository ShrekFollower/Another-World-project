using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameFinish : MonoBehaviour
{

    public GameObject Camera;
    public photoTaken PhotoTaken;

    void Start()
    {
        PhotoTaken = Camera.GetComponent<photoTaken>();
    }

    void Update()
    {
        if(PhotoTaken.nextTask == 6)
        {
            SceneManager.LoadScene("PhotoReel");
        }
    }
}
