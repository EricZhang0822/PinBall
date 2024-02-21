using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Final_point : MonoBehaviour
{
    public TMP_Text final_point;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        final_point.text = "Your Lucky Points:" + LP.score;


    }
}