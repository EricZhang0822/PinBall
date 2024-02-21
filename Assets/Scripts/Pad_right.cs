using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad_right : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 force;
    [SerializeField] private Vector2 setForce;
    [SerializeField] private float time;
    [SerializeField] private AudioSource whoosh;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        whoosh = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.D) && time <= 0)
        {
            whoosh.Play();
            rb.AddForce(transform.up * force, ForceMode2D.Impulse);
            force = setForce;
            time = 0.2f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            force += new Vector2(0, -0.05f);
        }

        if(force.magnitude > -49)
        {
            force.y = -25;
        }


    }
}
