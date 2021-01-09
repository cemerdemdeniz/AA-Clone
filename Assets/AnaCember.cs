using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject kucukcember;
    GameObject OyunYonetıcısı;
   
    void Start()
    {
        OyunYonetıcısı = GameObject.FindGameObjectWithTag("OyunYonetıcısıTag");
        
    }

    
    void Update()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            CreateLitteCircle();
        } 
    }
    void CreateLitteCircle()
    {
        Instantiate(kucukcember, transform.position , transform.rotation) ;
        OyunYonetıcısı.GetComponent<oyunyonetıcısı>().Kucukcemberlerdetextgosterme();

    }
}
