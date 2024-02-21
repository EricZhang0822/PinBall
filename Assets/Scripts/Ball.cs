using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private List<AudioSource> pingpong_sounds = new List<AudioSource>();
    [SerializeField] private AudioSource finalsound;
    [SerializeField] private float time;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (time <= 0)
        {
            int Random_Index = Random.Range(0, pingpong_sounds.Count);
            pingpong_sounds[Random_Index].Play();
            time = 1f;
        }

        if (col.gameObject.CompareTag("endpoint") && !finalsound.isPlaying)
        {
            finalsound.Play();

        }

    }
}
