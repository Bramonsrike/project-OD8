using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor_shoot : MonoBehaviour {

    public GameObject bullet;
    //private Rigidbody2D rb2d;


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("mouse 0"))
        {
            shoot();
        }
	}

    void shoot()
    {
        //rb2d = bullet.GetComponent<Rigidbody2D>();
        //Vector2 playerpos = Camera.main.WorldToScreenPoint();
        //rb2d.AddForce(Vector2.right*2);
        Instantiate(bullet, transform.position, transform.rotation);
    }

}
