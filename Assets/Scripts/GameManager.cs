using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject theBall;
    [SerializeField] private AudioSource generate;
    // Start is called before the first frame update
    void Start()
    {
        generate = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            generate.Play();
            theBall.transform.position = new Vector3(Random.Range(-2.3f, 2.3f), Random.Range(-2.5f, -3f));
        }


    }

}
