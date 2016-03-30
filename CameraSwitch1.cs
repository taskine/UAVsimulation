using UnityEngine;
using System.Collections;

public class CameraSwitch1 : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;

    // Use this for initialization
    void Start()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
        }
        else if (Input.GetKey("2"))
        {
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
        }
        else if (Input.GetKey("3"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
            camera4.enabled = false;
            camera5.enabled = false;
        }
        else if (Input.GetKey("4"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = true;
            camera5.enabled = false;
        }
        else if (Input.GetKey("5"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = true;
        }

    }
}