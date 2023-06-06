using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkUI : MonoBehaviour
{

    public GameObject camera;
    public Image original;
    public Sprite image1;
    public Sprite image2;
    public cameraCollider cameraCollider;

    void Start()
    {
        cameraCollider = camera.GetComponent<cameraCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cameraCollider.targetCheck == 1)
        {
            original.sprite = image1;
        }

        if(cameraCollider.targetCheck == 0)
        {
            original.sprite = image2;
        }
    }
}
