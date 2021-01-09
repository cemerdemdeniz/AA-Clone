﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunyonetıcısı : MonoBehaviour
{
    GameObject Cember;
    GameObject AnaCember;
    public Animator animator;
    public Text DonenCemberLevel1;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kacTaneKucukCemberOlsun;
    bool kontrol = true;
    void Start()
    {
        PlayerPrefs.SetInt("kayıt",int.Parse(SceneManager.GetActiveScene().name));
        
        Cember = GameObject.FindGameObjectWithTag("DonenCemberTag");
        AnaCember = GameObject.FindGameObjectWithTag("AnaCemberTag");
        DonenCemberLevel1.text = SceneManager.GetActiveScene().name;
        if (kacTaneKucukCemberOlsun<2)
        {
            bir.text = kacTaneKucukCemberOlsun+"";
        }
        else if (kacTaneKucukCemberOlsun<3)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun-1) + "";
        }
        else
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = (kacTaneKucukCemberOlsun - 2) + "";
        }
       
    }
    public void Kucukcemberlerdetextgosterme()
    {
        kacTaneKucukCemberOlsun--;
        if (kacTaneKucukCemberOlsun < 2)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = "";
            uc.text = "";
        }
        else if (kacTaneKucukCemberOlsun < 3)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = "";
        }
        else
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = (kacTaneKucukCemberOlsun - 2) + "";
        }
        if (kacTaneKucukCemberOlsun==0)
        {
            StartCoroutine(yeniLevel());
        }
    }
    IEnumerator yeniLevel()
    {
        Cember.GetComponent<Dondurme>().enabled = false;
        AnaCember.GetComponent<AnaCember>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        if (kontrol)
        {
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
       
    }


     public void OyunBitti()
    {
        StartCoroutine(CagrılanMetot());
    }

     IEnumerator CagrılanMetot()
    {
        
        Cember.GetComponent<Dondurme>().enabled = false;
        AnaCember.GetComponent<AnaCember>().enabled = false;
        animator.SetTrigger("Oyunbitti");
        kontrol = false;
        yield return new WaitForSeconds(2);//1 saniye bekletme
        
        
        SceneManager.LoadScene("MainMenu");
    }
    
   
}
