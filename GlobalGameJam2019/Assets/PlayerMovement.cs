using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float playerSpeed = 5;
    public bool hasPot = false;
    float speed = 5;

    Points points = new Points();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var v3 = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(speed * v3.normalized * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col) {
        hasPot = true;
        if(col.gameObject.tag == "boat") {
            //Application.LoadLevel(Application.loadedLevel);
            points.GainPoints(50);
        }
        if(col.gameObject.tag == "hazzard") {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
