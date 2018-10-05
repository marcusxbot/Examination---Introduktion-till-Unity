using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skeppet : MonoBehaviour
{

    public Color color;
    public SpriteRenderer rend;
    public float time;
    public float movespeed = 1;
    public float rotationspeed = -5;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))         // vilken knapp  
        {
            transform.Rotate(0, 0, rotationspeed);     // rotera höger
            rend.color = Color.blue;         // objekt blir blå
        }
        if (Input.GetKey(KeyCode.A))         //vilken knapp
        {
            transform.Rotate(0, 0, rotationspeed + 9.5f);      // roterar vänster
            rend.color = Color.green;        // objekt blir grön
        }

        transform.Translate(0, movespeed, 0);    // Åker alltid framåt

        if (Input.GetKey(KeyCode.S))         // vilken knapp
        {
            transform.Translate(0, movespeed - 0.5f, 0); // Hastigheten framåt
        }
        time += Time.deltaTime;
        Debug.Log(string.Format("Timer {0}", time));   // timer som visar

        if (Input.GetKey(KeyCode.Space))
        {
            
        }
    }
}
