using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photoTaken : MonoBehaviour
{

    public string photoName;
    public GameObject TaskBoard;
    public GameObject Camera;
    public taskSystem taskSystem;
    public cameraCollider cameraCollider;
    public int nextTask = 0;

    // Start is called before the first frame update
    
    private void Start()
    {
        taskSystem = TaskBoard.GetComponent<taskSystem>();
        cameraCollider = Camera.GetComponent<cameraCollider>();
    }
    
    private void Update()
    {

        photoName = taskSystem.nowTask;

        if(Input.GetMouseButtonDown(0) && cameraCollider.targetCheck == 1){ // capture screen shot on left mouse button down

            string folderPath = "Assets/Photos/"; // the path of your project folder

            if (!System.IO.Directory.Exists(folderPath)) // if this path does not exist yet
                System.IO.Directory.CreateDirectory(folderPath);  // it will get created
            
            var screenshotName =
                                    photoName + ".png"; 
            ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName),2); // takes the sceenshot.
            Debug.Log(folderPath + screenshotName); // You get instant feedback in the console
            nextTask ++;
            
        }
    }
}
