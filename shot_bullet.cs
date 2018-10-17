using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_bullet : MonoBehaviour {

    public GameObject Bullet;
    private GameObject gun;

    public float Bullet_Speed;

    private Rigidbody2D rb2d;
    private Transform btr;
    private Transform ptr;

    void Start()
    {
        //gun object fixen, want schieten vanaf gun object
        gun = GameObject.Find("Gun");

        //bullet en player components fixen
        rb2d = Bullet.GetComponent<Rigidbody2D>();
        btr = Bullet.GetComponent<Transform>();
        ptr = gun.GetComponent<Transform>();
        
        //positie van muis en player t.o.v scherm assenstel
        Vector2 mpos = Input.mousePosition;
        Vector2 ppos = Camera.main.WorldToScreenPoint(ptr.position);

        //vector berekening voor krachtvector van bullet
        Vector2 KrachtVector = mpos - ppos;
        //krachtvector normalizeren
        KrachtVector /= Mathf.Sqrt((KrachtVector.x * KrachtVector.x) + (KrachtVector.y * KrachtVector.y));

        //rotatie op bullet berekenen, hoek tussen X-as en krachtvector
        //krachtenvector ligt onder X-as
        float angle;
        if (KrachtVector.y < 0)
        {
            angle = -Mathf.Acos((KrachtVector.x))*(360/(2*Mathf.PI)); //inwendig product om hoek te berekenen + omzetten van radialen naar graden
        }
        //krachtenvector ligt boven x-as
        else
        {
            angle = Mathf.Acos((KrachtVector.x)) * (360/(2*Mathf.PI));
        }

        //bullet draaien om angle rond z-as
        btr.Rotate(new Vector3(0, 0, angle));


        //kracht laten inwerken op bullet in richting en zin van krachtvector en grootte Bullet_Speed
        rb2d.AddForce(KrachtVector*Bullet_Speed);

    }
	
}
