using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;

public class EightForce : MonoBehaviour
{
    public Rigidbody drone_Self;
    public Rigidbody drone2;
    public Rigidbody drone3;
    public Rigidbody drone4;
    public Rigidbody drone5;
    public Rigidbody drone6;
    public Rigidbody drone7;
    public Rigidbody drone8;

    //private variables
    private Rigidbody[] drone;
    private int totalDrones;

    void Start()
    {
        //Setting the drone Number
        totalDrones = 8;

        //Setting drones into an array
        drone = new Rigidbody[totalDrones];
        drone[0] = drone_Self;
        drone[1] = drone2;
        drone[2] = drone3;
        drone[3] = drone4;
        drone[4] = drone5;
        drone[5] = drone6;
        drone[6] = drone7;
        drone[7] = drone8;
    }

    void FixedUpdate()
    {
        //Initilizing the gain constants
        float K1, K2, Gamma, a;
        float aij, bij;

        //Getting the Gains constants from initialization
        a = 0.3f;
        K1 = EightInit.k1;
        K2 = EightInit.k2;
        Gamma = EightInit.gamma;

        //Setting the gain constants
        aij = (a * drone[0].mass);
        bij = (drone[0].mass * Gamma * a);

        //Initialize Variables to calculate the distances
        Vector3[] distance_selfTo;
        distance_selfTo = new Vector3[totalDrones];

        //Private vectors for calcuation of rotation and angularVelocity
        Vector3 rot1, rot2, rot3, rot4, angularVel;

        //Setting 0 so that we don't get garbage values
        Vector3 force = Vector3.zero;
        Vector3 rotation = Vector3.zero;

        //Initialize the Inertia Tensor of the UAV
        drone_Self.inertiaTensor = new Vector3(0.13f, 0.13f, 0.04f);
        Vector3 tensor = drone_Self.inertiaTensor;

        //Initialize the thurst to be applied
        float thrust;
        int count = 0;

        //Calculating the distance from Self drone to all other drones
        for (count = 0; count < totalDrones; count++)
        {
            distance_selfTo[count] = drone[0].transform.position - drone[count].transform.position;
        }

        //Calculating force from the algorithm
        for (count = 1; count < totalDrones; count++)
        {
            force = force + ((aij * distance_selfTo[count]) + (bij * (drone[0].velocity - drone[count].velocity)));
        }

        //Calculating the Thrust to be applied
        thrust = Vector3.Dot(force, drone[0].transform.forward);

        //Calculating the rotation vector
        angularVel = drone[0].angularVelocity;
        rot4 = Vector3.Cross(angularVel, force);
        rot3 = (K1 * K1 * K2) * (angularVel - (K1 * Vector3.Cross(force, drone[0].transform.forward)));
        rot2 = K1 * (Vector3.Scale(tensor, (Vector3.Cross(rot4, drone[0].transform.forward))));
        rot1 = Vector3.Cross(angularVel, Vector3.Scale(tensor, angularVel));
        rotation = rot1 - rot2 - rot3;

        //Applying the force and torque
        drone[0].AddForce(drone[0].transform.forward * (-thrust), ForceMode.Force);
        drone[0].AddTorque(rotation);
    }
}
