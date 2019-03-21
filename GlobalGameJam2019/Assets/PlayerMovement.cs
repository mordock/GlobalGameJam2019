using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float playerSpeed = 5;
    public bool hasPot = false;
    float speed = 5;

    private Points points;
    private bool canPickUp = false;

    private GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.Find("Text").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        var v3 = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(speed * v3.normalized * Time.deltaTime);

        if (Input.GetKey(KeyCode.E) && canPickUp) {
            hasPot = true;
            Destroy(objectToDestroy);
            canPickUp = false;
            SpawnPots.potExists = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("coll");
        if(col.gameObject.tag == "hazzard") {
            Application.LoadLevel(Application.loadedLevel);
        }
        if(col.gameObject.tag == "pot") {
            Debug.Log("pot");
            canPickUp = true;
            objectToDestroy = col.gameObject;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "boat") {
            //Application.LoadLevel(Application.loadedLevel);
            points.GainPoints(50);
        }
    }
}
