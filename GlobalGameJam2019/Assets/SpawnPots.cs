﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPots : MonoBehaviour
{
    public float timeLeft = 5;
    public GameObject pot;

    public static bool potExists = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 1 * Time.deltaTime;
        if(timeLeft <= 0 && potExists == false) {
            Instantiate(pot, new Vector3(7, 0, 0), Quaternion.identity);
            timeLeft = 5;
            potExists = true;
        }
    }
}
