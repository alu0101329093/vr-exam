using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ObjectController.OnLook += Jump;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jump() {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 100);
    }
}
