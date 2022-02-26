using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    float speed = 30;
    public GameObject ball;
    public GameObject ball_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ball_y = ball.transform.position.y;
        float ball_x = ball.transform.position.x;
        float ball_2_y = ball_2.transform.position.y;
        float ball_2_x = ball_2.transform.position.x;
        float rocket_y = transform.position.y;
        float rocket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
        float direction;

        if (ball_x > 0 || ball_2_x > 0)
        {
            if (true) //اگر جهت حرکت توپ مثبت بود
            {
                if (ball_y + rocket_h < rocket_y || ball_2_y + rocket_h < rocket_y)
                {
                    direction = -1;
                }
                else if (ball_y - rocket_h > rocket_y || ball_2_y - rocket_h > rocket_y)
                {
                    direction = 1;
                }
                else
                {
                    direction = 0;
                }

                GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
            }
        }
    }
}
