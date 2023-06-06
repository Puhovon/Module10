using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapController : MonoBehaviour
{
    public float rad;
    public LayerMask layerM;

    // Start is called before the first frame update
    void Start()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, rad, layerM);

        foreach (Collider col in colls)
        {
            col.gameObject.transform.localScale *= 1.5f;
            Debug.Log(col.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
