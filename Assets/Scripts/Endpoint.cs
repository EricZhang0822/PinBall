using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpoint : MonoBehaviour
{
    [SerializeField] private GameObject Prevlevel;
    [SerializeField] private GameObject level;
    [SerializeField] private GameObject Nextlevel;
    [SerializeField] private GameObject rules;
    [SerializeField] private GameObject sth;
    [SerializeField] private float time;
    [SerializeField] private AudioSource touched;



    // Start is called before the first frame update
    void Start()
    {
        touched = GetComponent<AudioSource>();
        if(touched != null && !touched.isPlaying)
        {
            touched.Play();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        time -= Time.deltaTime;
        
        if (Lives.lives == 0)
        {
            Prevlevel.SetActive(true);
            level.SetActive(false);
            LP.score -= 50;
            Lives.lives = 3;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = new Vector3(Random.Range(-2, 2), Random.Range(-1, 1));
            LP.score += (int)time;
            if(sth != null)
            {
                sth.SetActive(true);
            }
            if (rules != null)
            {
                rules.SetActive(false);
            }
            level.SetActive(false);
            
            Nextlevel.SetActive(true);

            
        }
    }
}
