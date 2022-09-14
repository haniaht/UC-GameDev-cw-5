using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticle : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(speed,0f, 0f );
    }
}
