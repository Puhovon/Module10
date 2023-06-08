using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float pauseTime, freeTime, power;
    private Rigidbody rb;


    private float _currentPauseTime, _currentFreeTime;

    void Start()
    {
        _currentPauseTime = pauseTime;
        _currentFreeTime = freeTime;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _currentFreeTime -= Time.deltaTime;
        if (_currentFreeTime <= 0 && _currentPauseTime > 0)
        {
            rb.AddForce(0, 0, -power, ForceMode.Acceleration);
            _currentPauseTime -= Time.deltaTime;
        }
        else if (_currentPauseTime <= 0)
        {
            _currentFreeTime = freeTime;
            _currentPauseTime = pauseTime;
        }
    }

}
