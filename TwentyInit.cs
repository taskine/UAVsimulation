using UnityEngine;
using System.Collections;

public class TwentyInit : MonoBehaviour
{
    //Input parameter for velocity and angularVelocity of drones
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
    public Vector3 Velocity9;
    public Vector3 AngularVelocity9;
    public Vector3 Velocity10;
    public Vector3 AngularVelocity10;
    public Vector3 Velocity11;
    public Vector3 AngularVelocity11;
    public Vector3 Velocity12;
    public Vector3 AngularVelocity12;
    public Vector3 Velocity13;
    public Vector3 AngularVelocity13;
    public Vector3 Velocity14;
    public Vector3 AngularVelocity14;
    public Vector3 Velocity15;
    public Vector3 AngularVelocity15;
    public Vector3 Velocity16;
    public Vector3 AngularVelocity16;
    public Vector3 Velocity17;
    public Vector3 AngularVelocity17;
    public Vector3 Velocity18;
    public Vector3 AngularVelocity18;
    public Vector3 Velocity19;
    public Vector3 AngularVelocity19;
    public Vector3 Velocity20;
    public Vector3 AngularVelocity20;

    //Drones used for the simulation
    public Rigidbody drone1;
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
        //Setting the velocity of drones
        drone1.velocity = Velocity1;
        drone2.velocity = Velocity2;
        drone3.velocity = Velocity3;
        drone4.velocity = Velocity4;
        drone5.velocity = Velocity5;
        drone6.velocity = Velocity6;
        drone7.velocity = Velocity7;
        drone8.velocity = Velocity8;
        drone9.velocity = Velocity9;
        drone10.velocity = Velocity10;
        drone11.velocity = Velocity11;
        drone12.velocity = Velocity12;
        drone13.velocity = Velocity13;
        drone14.velocity = Velocity14;
        drone15.velocity = Velocity15;
        drone16.velocity = Velocity16;
        drone17.velocity = Velocity17;
        drone18.velocity = Velocity18;
        drone19.velocity = Velocity19;
        drone20.velocity = Velocity20;

        //Setting the angular Velocity of drones
        drone1.angularVelocity = AngularVelocity1;
        drone2.angularVelocity = AngularVelocity2;
        drone3.angularVelocity = AngularVelocity3;
        drone4.angularVelocity = AngularVelocity4;
        drone5.angularVelocity = AngularVelocity5;
        drone6.angularVelocity = AngularVelocity6;
        drone7.angularVelocity = AngularVelocity7;
        drone8.angularVelocity = AngularVelocity8;
        drone9.angularVelocity = AngularVelocity9;
        drone10.angularVelocity = AngularVelocity10;
        drone11.angularVelocity = AngularVelocity11;
        drone12.angularVelocity = AngularVelocity12;
        drone13.angularVelocity = AngularVelocity13;
        drone14.angularVelocity = AngularVelocity14;
        drone15.angularVelocity = AngularVelocity15;
        drone16.angularVelocity = AngularVelocity16;
        drone17.angularVelocity = AngularVelocity17;
        drone18.angularVelocity = AngularVelocity18;
        drone19.angularVelocity = AngularVelocity19;
        drone20.angularVelocity = AngularVelocity20;
    }

    void Update()
    {
        // do nothing
    }
}
