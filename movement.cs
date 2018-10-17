using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    private Vector2 position;
    public float speed;

	// Use this for initialization
	void Start () {
        position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
            position.x += speed;
            transform.position = position;
        }
        if (Input.GetKey("q"))
        {
            position.x -= speed;
            transform.position = position;
        }
        if (Input.GetKey("z"))
        {
            position.y += speed;
            transform.position = position;
        }
        if (Input.GetKey("s"))
        {
            position.y -= speed;
            transform.position = position;
        }
    }
}
