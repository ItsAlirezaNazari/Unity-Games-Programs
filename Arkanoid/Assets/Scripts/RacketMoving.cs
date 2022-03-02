using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMoving : MonoBehaviour
{
    public float speed = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // left or A : -1
        // right or D : 1
        float h = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
