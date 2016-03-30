using UnityEngine;
using System.Collections;

public class EightCam : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera Bird;

    // Use this for initialization
    void Start()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
        camera8.enabled = false;
        Bird.enabled = true;
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
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("2"))
        {
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("3"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("4"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = true;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("5"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = true;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("6"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = true;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("7"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = true;
            camera8.enabled = false;
            Bird.enabled = false;
        }
        else if (Input.GetKey("8"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = true;
            Bird.enabled = false;
        }
        else if (Input.GetKey("9"))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            Bird.enabled = true;
        }

    }
}