using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_2 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float vel1;
    [SerializeField] private float vel2;
    private bool GetVel = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetVel)
        {
            rb.velocity = new Vector2(Random.Range(vel1, vel2), 0);
            GetVel = true;
        }

        if(rb.velocity.x > 10)
        {
            rb.velocity = new Vector2(Random.Range(vel1, vel2), 0);
        }else if(rb.velocity.magnitude < 2)
        {
            rb.velocity = new Vector2(Random.Range(vel1, vel2), 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Frame"))
            rb.velocity = -(rb.velocity + new Vector2(0f,1.5f)) * 1.1f;
    }
}
