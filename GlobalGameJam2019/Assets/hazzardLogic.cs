using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazzardLogic : MonoBehaviour
{
    public float hazzardSpeed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, hazzardSpeed * Time.deltaTime, 0);
    }
}
