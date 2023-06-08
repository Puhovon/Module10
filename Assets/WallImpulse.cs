using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallImpulse : MonoBehaviour
{
    [SerializeField] float _maxPower = 5, _minPower = -5;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            collision.rigidbody.AddForce(_minPower, 0, _maxPower, ForceMode.Impulse);
        }
    }
}
