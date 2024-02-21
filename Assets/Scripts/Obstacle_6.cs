using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_6 : MonoBehaviour
{
    [SerializeField] private float Force;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AudioSource field;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        field = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Force > 8)
            Force -= 0.01f;
        else if (Force < 2)
            Force += 0.01f;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D ballrb = collision.gameObject.GetComponent<Rigidbody2D>();

            if(ballrb != null)
            {
                Vector2 dirToCenter = (Vector2)transform.position - ballrb.position;
                dirToCenter.Normalize();
                ballrb.AddForce(dirToCenter * Force);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            field.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            field.Stop();
    }


}
