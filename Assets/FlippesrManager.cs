using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippesrManager : MonoBehaviour
{
    [SerializeField]
    private HingeJoint leftFlipper, rigthFlipper;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            leftFlipper.useMotor = true;
        }
    }
}
