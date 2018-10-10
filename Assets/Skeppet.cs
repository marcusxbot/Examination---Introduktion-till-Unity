using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skeppet : MonoBehaviour
{

    public Color color;
    public SpriteRenderer rend;
    private float time;
    public float movespeed;
    private float rotationspeedH = -5;
    private float rotationspeedV = 4.5f;
    private float Färg1;
    private float Färg2;
    private float Färg3;
    private int ok;
    private int Vector3;





    // Use this for initialization
    void Start()
    {
        movespeed += Random.Range(1, 5);

        //  skeppet spawnar på en random position innanför skärmen när spelet startar
        Vector3 position = new Vector3(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f), 0);
            transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))         // vilken knapp  
        {
            transform.Rotate(0, 0, rotationspeedH);     // rotera höger
            rend.color = Color.blue;         // objekt blir blå
        }
        if (Input.GetKey(KeyCode.A))         //vilken knapp
        {
            transform.Rotate(0, 0, rotationspeedV);      // roterar vänster
            rend.color = Color.green;        // objekt blir grön
        }

        transform.Translate(0, movespeed, 0);    // Åker alltid framåt

        if (Input.GetKeyDown(KeyCode.S))         // vilken knapp
        {
            movespeed = movespeed / 2;              // Hastigheten framåt
        }
        if (Input.GetKeyUp(KeyCode.S))           // vilken knapp
        {
            movespeed = movespeed * 2;           // hastigheten framåt
        }
   

        time += Time.deltaTime;
        if (time >= ok + 1)
        {                                   // timer
            ok += 1;
            Debug.Log("Timer " + ok);
        }
           // timer som visar


        if (Input.GetKey(KeyCode.Space))      // vilken knapp
        {
            Färg1 = Random.Range(0f, 1f);
            Färg2 = Random.Range(0f, 1f);       // färg
            Färg3 = Random.Range(0f, 1f);
            rend.color = new Color (Färg1, Färg2, Färg3); 
        }
        // när skeppet går förbi position -338 x warp till position 280 x
        if (transform.position.x < -338)
        {
            transform.position = new Vector3(280, transform.position.y);
        }
        // när skeppet går förbi position 280 x warp till position -338 x
        if (transform.position.x > 280)
        {
            transform.position = new Vector3(-338, transform.position.y);
        }
        // när skeppet går förbi position -183 y warp till position 160 y
        if (transform.position.y < -160)
        {
            transform.position = new Vector3(transform.position.x, 183);
        }
        // när skeppet går förbi position 183 y warp till position -160 y
        if (transform.position.y > 183)
        {
            transform.position = new Vector3(transform.position.x, -160);
        }
    }

}
