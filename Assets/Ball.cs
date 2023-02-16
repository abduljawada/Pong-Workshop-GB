using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(1, 1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
