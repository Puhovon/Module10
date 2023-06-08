using UnityEngine;

public class ImpulseToBall : MonoBehaviour
{
    [SerializeField] private Transform pos;
    private Rigidbody rb;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(pos.position.normalized * power, ForceMode.Force);
        }
    }
}
