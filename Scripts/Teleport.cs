using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float maxX;
    public float maxZ;
    public bool inCooldown;
    public float cooldownTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float teleport = Input.GetAxisRaw("Teleport");

        if (teleport == 1 && !inCooldown) {
            // Transform tf = GetComponent<Transform>();
            // tf.position = 
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 teleportPosition = new Vector3(Random.Range(-maxX, maxX), 0, Random.Range(-maxZ, maxZ));
            rb.MovePosition(teleportPosition);
            inCooldown = true;
            StartCoroutine(ResetCoolDown());
        }
    }

    IEnumerator ResetCoolDown()
    {
        yield return new WaitForSeconds(cooldownTime);
        inCooldown = false;
    }
}
