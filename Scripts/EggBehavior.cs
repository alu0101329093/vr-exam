using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScaleEggs.OnScaleEgg += Scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Scale(float factor) {
        Debug.Log("Scale");
        transform.localScale *= factor;
    }
}
