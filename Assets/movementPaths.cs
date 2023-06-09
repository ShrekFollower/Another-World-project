using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPaths : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject obj;
    public GameObject[] pathPoints;
    public int numberOfPoints;
    public float speed;

    private Vector3 actualPosition;
    private int x;

    void Start()
    {
        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        actualPosition = obj.transform.position;
        obj.transform.position = Vector3.MoveTowards(actualPosition, pathPoints[x].transform.position, speed * Time.deltaTime);

        if(actualPosition == pathPoints[x].transform.position && x != numberOfPoints - 1)
        {
            x++;
            if(x == 4)
            {
                x = 1;
            }
        }

        if(actualPosition == pathPoints[x].transform.position && x == 4)
        {
            x = 1;
        }
    }
}
