using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class photoReel : MonoBehaviour
{

    public Image original;
    public Sprite[] nowSprite = new Sprite [7];
    public int photoNum;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            photoNum ++;
        }

        original.sprite = nowSprite[photoNum];

        if(photoNum == 7)
        {
            Application.Quit();
        }
    }

}
