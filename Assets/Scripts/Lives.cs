using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    public static int lives = 3;
    public TMP_Text _Lives;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _Lives.text = "Lives:" + lives;

    }
}
