using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    [SerializeField] private AudioSource stop;
    [SerializeField] private GameObject pads;
    [SerializeField] private GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        stop = GetComponent<AudioSource>();
        stop.Stop();
        pads.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        circle.transform.position = Vector3.zero;
    }
}
