using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Polarith.AI.Package; 

public class CarControllerP : MonoBehaviour
{
   
public VehiclePhysics vehicle;



private void OnEnable()
{

    vehicle = GetComponent<VehiclePhysics>();
}

private void Update()
{

    float steering = 0.0f;
    float acceleration = 0.0f;
    if (Input.GetKey(KeyCode.A))
        steering= -1.0f;
    else if (Input.GetKey(KeyCode.D))
           steering = 1.0f;
    vehicle.Move(steering,acceleration, 0.0f);       
}

}
