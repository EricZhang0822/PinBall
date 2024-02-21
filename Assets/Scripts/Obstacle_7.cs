using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_7 : MonoBehaviour
{
    [SerializeField] private Transform gate1;
    [SerializeField] private Transform gate2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = new Vector3(gate1.position.x, (gate1.position.y + gate2.position.y) / 2, 0);
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(9,0);

        }
    }
}
