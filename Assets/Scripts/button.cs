using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] private GameObject Level1;
    [SerializeField] private GameObject pads;
    [SerializeField] private GameObject third_thing;
    [SerializeField] private GameObject end;
    [SerializeField] private GameObject endscene;
    [SerializeField] private AudioSource replay;

    // Start is called before the first frame update
    void Start()
    {
        replay = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        LP.score = 0;
        Lives.lives = 3;
        Level1.SetActive(true);
        pads.SetActive(true);
        end.SetActive(false);
        endscene.SetActive(false);
        
    }

}
