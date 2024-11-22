using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Texts : MonoBehaviour
{
    public GameObject TelaIni;
    public GameObject Context;
    public GameObject Final;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SeeTelaIni()
    {
        TelaIni.SetActive(false);
        Context.SetActive(true);
    }
    
    public void SeeFinal()
    {
        Context.SetActive(false);
        Final.SetActive(true);
    }
}
