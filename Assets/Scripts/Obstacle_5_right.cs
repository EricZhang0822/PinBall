using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_5_right : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float Force;
    [SerializeField] private float step;
    private Vector3 StartPos;
    private bool reset = false;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (reset)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, StartPos, step);
        }

        if(transform.position == StartPos)
        {
            reset = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!reset)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                this.transform.position += new Vector3(0.3f, 0, 0);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * -1 * Force, ForceMode2D.Impulse);

                reset = true;
            }
        }
        
    }
}
