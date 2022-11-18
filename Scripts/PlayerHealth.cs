using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        SpiderAttack.OnAttack += ReceiveSpiderAttack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReceiveSpiderAttack(float damage)
    {
        health -= damage;
    }
}
