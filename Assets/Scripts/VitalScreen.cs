using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VitalScreen : MonoBehaviour
{
    
    public GameObject main;
    
    public Image original;
    public Sprite image;
    public Sprite image1;
    public Sprite image2;
    public playerHealth player;

    void Start()
    {
        player = main.GetComponent<playerHealth>();
    }

    void Update()
    {

        if(player.health == 3)
        {
            original.sprite = image;
        }
        
        if(player.health == 2)
        {
            original.sprite = image1;
        }

        if(player.health == 1)
        {
            original.sprite = image2;
        }
    }
}
