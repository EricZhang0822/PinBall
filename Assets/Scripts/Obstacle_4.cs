using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_4 : MonoBehaviour
{

    [SerializeField] private float RotateSpd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0,0,RotateSpd * Time.deltaTime);
    }
}
