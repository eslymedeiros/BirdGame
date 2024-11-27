using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Texts : MonoBehaviour
{
    public GameObject TelaIni;
    public GameObject Context;
    public GameObject Final;

    public static Texts instance;

    private void Start()
    {
        instance = this;
    }
    
    
    public void SeeTelaIni()
    {
        TelaIni.SetActive(false);
        Context.SetActive(true);
    }

    public void SeeContext()
    {
        Context.SetActive(false);
    }
    
    public void SeeFinal()
    {
        Final.SetActive(true);
    }

    public void Restart(string restart)
    {
        SceneManager.LoadScene(restart);
    }
}
