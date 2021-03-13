using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  [RequireComponent(typeof(InputManager))]
public class CarController2 : MonoBehaviour
     
{

 public InputManager Im;
 public List<WheelCollider> throttleWheels;
 public List<WheelCollider> steeringWheels;
 public float strengthCoefficient = 20000f;
 public float maxTurn = 20f;
    
// Start is called before the first frame update
    void Start()
    {
        Im = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttleWheels)
        {
        wheel.motorTorque = strengthCoefficient *Time.fixedDeltaTime * Im.throttle;
        
        }
        
        foreach  (WheelCollider wheel in steeringWheels)
        {
        wheel.steerAngle = maxTurn *Im.steer;
        
        }
        
    }
}
