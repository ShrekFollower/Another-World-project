using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    
    public int health = 3;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "attack")
        {
            health --;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("ForestMap");
        }
    }
}
