using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menukontrol : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();   
    }


    public void oyunaGit()
    {
        int kayıtlılevel = PlayerPrefs.GetInt("kayıt");
        if (kayıtlılevel==0)
        {
            SceneManager.LoadScene(kayıtlılevel + 1);
        }
        else
        {
            SceneManager.LoadScene(kayıtlılevel);
        }
    }
    
    public void Cık()
    {
        Application.Quit();
    }
}
