using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        Vector3 movementVector = (Vector3.forward * verticalAxis + Vector3.right * horizontalAxis);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movementVector * movementSpeed * Time.deltaTime, ForceMode.Acceleration);
    }
}
