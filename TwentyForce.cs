using UnityEngine;
using System.Collections;

public class TwentyForce : MonoBehaviour
{
    public Rigidbody drone_Self;
    public Rigidbody drone2;
    public Rigidbody drone3;
    public Rigidbody drone4;
    public Rigidbody drone5;
    public Rigidbody drone6;
    public Rigidbody drone7;
    public Rigidbody drone8;
    public Rigidbody drone9;
    public Rigidbody drone10;
    public Rigidbody drone11;
    public Rigidbody drone12;
    public Rigidbody drone13;
    public Rigidbody drone14;
    public Rigidbody drone15;
    public Rigidbody drone16;
    public Rigidbody drone17;
    public Rigidbody drone18;
    public Rigidbody drone19;
    public Rigidbody drone20;

    void Start()
    {
        // do nothing for now
    }

    void FixedUpdate()
    {
        //float distance2, distance3;
        Vector3 distance_selfTo2, distance_selfTo3, distance_selfTo4, distance_selfTo5, distance_selfTo6, distance_selfTo7, distance_selfTo8;
        Vector3 distance_selfTo9, distance_selfTo10, distance_selfTo11, distance_selfTo12, distance_selfTo13, distance_selfTo14, distance_selfTo15;
        Vector3 distance_selfTo16, distance_selfTo17, distance_selfTo18, distance_selfTo19, distance_selfTo20;
        Vector3 rot1, rot2, rot3, rot4;
        Vector3 angularVel;

        Vector3 force = Vector3.zero;
        Vector3 rotation = Vector3.zero;
        drone_Self.inertiaTensor = new Vector3(0.13f, 0.13f, 0.04f);
        Vector3 tensor = drone_Self.inertiaTensor;
        float thrust;

        //distance2 = Vector3.Distance(drone_Self.transform.position, drone2.transform.position);
        //distance3 = Vector3.Distance(drone_Self.transform.position, drone3.transform.position);

        distance_selfTo2 = drone_Self.transform.position - drone2.transform.position;
        distance_selfTo3 = drone_Self.transform.position - drone3.transform.position;
        distance_selfTo4 = drone_Self.transform.position - drone4.transform.position;
        distance_selfTo5 = drone_Self.transform.position - drone5.transform.position;
        distance_selfTo6 = drone_Self.transform.position - drone6.transform.position;
        distance_selfTo7 = drone_Self.transform.position - drone7.transform.position;
        distance_selfTo8 = drone_Self.transform.position - drone8.transform.position;
        distance_selfTo9 = drone_Self.transform.position - drone9.transform.position;
        distance_selfTo10 = drone_Self.transform.position - drone10.transform.position;
        distance_selfTo11 = drone_Self.transform.position - drone11.transform.position;
        distance_selfTo12 = drone_Self.transform.position - drone12.transform.position;
        distance_selfTo13 = drone_Self.transform.position - drone13.transform.position;
        distance_selfTo14 = drone_Self.transform.position - drone14.transform.position;
        distance_selfTo15 = drone_Self.transform.position - drone15.transform.position;
        distance_selfTo16 = drone_Self.transform.position - drone16.transform.position;
        distance_selfTo17 = drone_Self.transform.position - drone17.transform.position;
        distance_selfTo18 = drone_Self.transform.position - drone18.transform.position;
        distance_selfTo19 = drone_Self.transform.position - drone19.transform.position;
        distance_selfTo20 = drone_Self.transform.position - drone20.transform.position;

        force = (0.3f * distance_selfTo2) + (9 * (drone_Self.velocity - drone2.velocity));
        force = force + ((0.3f * distance_selfTo3) + (9 * (drone_Self.velocity - drone3.velocity)));
        force = force + ((0.3f * distance_selfTo4) + (9 * (drone_Self.velocity - drone4.velocity)));
        force = force + ((0.3f * distance_selfTo5) + (9 * (drone_Self.velocity - drone5.velocity)));
        force = force + ((0.3f * distance_selfTo6) + (9 * (drone_Self.velocity - drone6.velocity)));
        force = force + ((0.3f * distance_selfTo7) + (9 * (drone_Self.velocity - drone7.velocity)));
        force = force + ((0.3f * distance_selfTo8) + (9 * (drone_Self.velocity - drone8.velocity)));
        force = force + ((0.3f * distance_selfTo9) + (9 * (drone_Self.velocity - drone9.velocity)));
        force = force + ((0.3f * distance_selfTo10) + (9 * (drone_Self.velocity - drone10.velocity)));
        force = force + ((0.3f * distance_selfTo11) + (9 * (drone_Self.velocity - drone11.velocity)));
        force = force + ((0.3f * distance_selfTo12) + (9 * (drone_Self.velocity - drone12.velocity)));
        force = force + ((0.3f * distance_selfTo13) + (9 * (drone_Self.velocity - drone13.velocity)));
        force = force + ((0.3f * distance_selfTo14) + (9 * (drone_Self.velocity - drone14.velocity)));
        force = force + ((0.3f * distance_selfTo15) + (9 * (drone_Self.velocity - drone15.velocity)));
        force = force + ((0.3f * distance_selfTo16) + (9 * (drone_Self.velocity - drone16.velocity)));
        force = force + ((0.3f * distance_selfTo17) + (9 * (drone_Self.velocity - drone17.velocity)));
        force = force + ((0.3f * distance_selfTo18) + (9 * (drone_Self.velocity - drone18.velocity)));
        force = force + ((0.3f * distance_selfTo19) + (9 * (drone_Self.velocity - drone19.velocity)));
        force = force + ((0.3f * distance_selfTo20) + (9 * (drone_Self.velocity - drone20.velocity)));
        thrust = Vector3.Dot(force, drone_Self.transform.forward);

        angularVel = drone_Self.angularVelocity;
        rot4 = Vector3.Cross(angularVel, force);
        rot3 = 0.4f * (angularVel - (2 * Vector3.Cross(force, drone_Self.transform.forward)));
        rot2 = 2 * (Vector3.Scale(tensor, (Vector3.Cross(rot4, drone_Self.transform.forward))));
        rot1 = Vector3.Cross(angularVel, Vector3.Scale(tensor, angularVel));
        rotation = rot1 - rot2 - rot3;

        drone_Self.AddForce(drone_Self.transform.forward * (-thrust), ForceMode.Force);
        drone_Self.AddTorque(rotation);
    }
}