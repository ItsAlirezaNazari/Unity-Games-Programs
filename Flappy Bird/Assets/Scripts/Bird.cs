using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed = 2;
    public float force = 300; // Flap force

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // بال زدن
        // Flap
        if(Input.GetKeyDown(KeyCode.Space)) // اگر کاربر دکمه اسپیس را فشار داد
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }

    void OnCollisionEnter2D(Collision2D guest)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
