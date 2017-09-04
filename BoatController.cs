using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : GameUnit {

    public WheelCollider[] WColForward;
    public WheelCollider[] WColBack;
    

    public float maxSteer ; 
    public float maxAccel ; 
    public float maxBrake ; 

    //Centr of mass
    public Vector3 com;
    public Rigidbody rb;

    float accel = 0f;
    float steer = 0f;


    // Use this for initialization
    public virtual void Start()
    {
        //center of mass
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
    }


    void Update()
    {
       
        // waiting for inputs
        accel = Input.GetAxis("Vertical");  
        steer = Input.GetAxis("Horizontal");

        StartCoroutine(BoatMoveCoroutine());

    }

    IEnumerator BoatMoveCoroutine()
    {
        //Boat movement
        BoatMove(accel, steer);
        yield return new WaitForSeconds(1f);
       
    }

    // Boat Controls
    public void BoatMove(float accel, float steer)
    { 
        //Rotation of boat colliders
        foreach (WheelCollider collider in WColForward)
        { 
            collider.steerAngle = steer * maxSteer;

            //Debug.Log("angle " + collider.steerAngle);
        }

        //Braking
        if (accel == 0)
        { 
            foreach (WheelCollider collider in WColBack)
            {  
               collider.brakeTorque = maxBrake; 
            }

        }
        else
        { 
            //Acceleration
            foreach (WheelCollider collider in WColForward)
            { 
                collider.brakeTorque = 0; 
                collider.motorTorque = accel * maxAccel;
            }

            foreach (WheelCollider collider in WColBack)
            {
                collider.brakeTorque = 0;
                collider.motorTorque = accel * maxAccel;
            }

        }



    }

    
}
