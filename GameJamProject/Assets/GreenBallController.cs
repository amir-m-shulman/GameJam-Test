using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBallController : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
