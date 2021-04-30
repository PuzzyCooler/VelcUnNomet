using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class galvenaizvelne : MonoBehaviour
{
    public void izvelne()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Single);
    }
}


