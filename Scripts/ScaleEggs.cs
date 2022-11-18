using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleEggs : MonoBehaviour
{
    public delegate void ScaleEggEvent(float factor);
    public static event ScaleEggEvent OnScaleEgg;

    public float scaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.collider.tag == "Player") {
            OnScaleEgg(scaleFactor);
        }
    }
}
