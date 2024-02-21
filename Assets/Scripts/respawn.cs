using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private AudioSource damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            damage.Play();
            collision.gameObject.transform.position = new Vector3(Random.Range(-2.5f,2.5f), Random.Range(1f,-1f), 0);
            Lives.lives -= 1;
        }

    }
}
