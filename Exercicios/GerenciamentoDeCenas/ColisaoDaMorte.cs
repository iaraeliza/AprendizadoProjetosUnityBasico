using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisaoTrocaDeCena : MonoBehaviour
{

    public string Cena;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(Cena);
    }
}   