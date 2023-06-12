using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{

    public GameObject player;

    void Start()
    {
        transform.LookAt(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
}
