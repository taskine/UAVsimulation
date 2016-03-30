using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;


public class EightInit : MonoBehaviour
{
    //Input parameter for velocity and angularVelocity of drones
    public float GAIN_K1;
    public float GAIN_K2;
    public float GAIN_Gamma;
    public Vector3 Velocity1;
    public Vector3 AngularVelocity1;
    public Vector3 Velocity2;
    public Vector3 AngularVelocity2;
    public Vector3 Velocity3;
    public Vector3 AngularVelocity3;
    public Vector3 Velocity4;
    public Vector3 AngularVelocity4;
    public Vector3 Velocity5;
    public Vector3 AngularVelocity5;
    public Vector3 Velocity6;
    public Vector3 AngularVelocity6;
    public Vector3 Velocity7;
    public Vector3 AngularVelocity7;
    public Vector3 Velocity8;
    public Vector3 AngularVelocity8;
    
    public static float k1;
    public static float k2;
    public static float gamma;

    //Drones used for the simulation
    public Rigidbody drone1;
    public Rigidbody drone2;
    public Rigidbody drone3;
    public Rigidbody drone4;
    public Rigidbody drone5;
    public Rigidbody drone6;
    public Rigidbody drone7;
    public Rigidbody drone8;

    void Start()
    {
        //Setting gain for K1 
        if (GAIN_K1 == 0)
        {
            k1 = 2.0f;
        }
        else {
            k1 = GAIN_K1;
        }

        //Setting the gain for K2
        if (GAIN_K2 == 0)
        {
            k2 = 0.1f;
        }
        else {
            k2 = GAIN_K2;
        }

        //Setting the value for Gamma
        if (GAIN_Gamma == 0)
        {
            gamma = 30.0f;
        }
        else {
            gamma = GAIN_Gamma;
        }

        //Setting the velocity of drones
        drone1.velocity = Velocity1;
        drone2.velocity = Velocity2;
        drone3.velocity = Velocity3;
        drone4.velocity = Velocity4;
        drone5.velocity = Velocity5;
        drone6.velocity = Velocity6;
        drone7.velocity = Velocity7;
        drone8.velocity = Velocity8;

        //Setting the angular Velocity of drones
        drone1.angularVelocity = AngularVelocity1;
        drone2.angularVelocity = AngularVelocity2;
        drone3.angularVelocity = AngularVelocity3;
        drone4.angularVelocity = AngularVelocity4;
        drone5.angularVelocity = AngularVelocity5;
        drone6.angularVelocity = AngularVelocity6;
        drone7.angularVelocity = AngularVelocity7;
        drone8.angularVelocity = AngularVelocity8;
    }

    void Update()
    {
        // do nothing
    }
}

