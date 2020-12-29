using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kucukcembersc : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool haraketkontrol = false;
    GameObject oyunYoneticisi;
    


    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYonetıcısıTag");      
    }

    
    void FixedUpdate()
        
    {
        if (!haraketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
        
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="DonenCemberTag")
        {
            transform.SetParent(col.transform);
            haraketkontrol = true;
            
        }
        if (col.tag=="KucukCemberTag")
        {

            oyunYoneticisi.GetComponent<oyunyonetıcısı>().OyunBitti();
        }



    }

}
