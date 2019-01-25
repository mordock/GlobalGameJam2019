using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazzardSpawn : MonoBehaviour
{
    public float timeLeft;
    public float newTime;
    public GameObject hazzard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 1 * Time.deltaTime;
        if (timeLeft <= 0) {
            Instantiate(hazzard, transform.position, Quaternion.identity);
            timeLeft = newTime;
        }
    }
}
