using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzvarasSkripts : MonoBehaviour
{
    private int Uzvara;
    private int punkti;
    public GameObject objektuSkripts;
        
    void Start()
    {
        Uzvara = objektuSkripts.transform.childCount;
    }


    void Update()
    {
        if (punkti >= Uzvara)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    public void pievPunkt()
    {
        punkti++;
    }
}
