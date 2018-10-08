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





    // Use this for initialization
    void Start()
    {
        movespeed += Random.Range(0, 5);
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

        
        
            
    }
}
