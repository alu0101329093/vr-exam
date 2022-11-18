using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ObjectController.OnLook += Rotate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Rotate() {
        transform.Rotate(0,180,0);
    }
}
