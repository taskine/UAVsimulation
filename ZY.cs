using UnityEngine;
using System.Collections;

public class ZY : MonoBehaviour {

    public Rigidbody drone;
    public Camera camera;
    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        offset = transform.position - drone.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = drone.transform.position + offset;
        //camera.transform.position = new Vector3(camera.transform.position.x, (drone.transform.position.y - offset), camera.transform.position.z);
    }
}
