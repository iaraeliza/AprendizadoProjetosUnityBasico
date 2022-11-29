using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dificuldade : MonoBehaviour
{
    [SerializeField] public Dropdown dropdown;
    [SerializeField] public int dificuldade;
    //não pode ser alterado, apenas ler
    [SerializeField] readonly string keyDificuldade = "KEY_DIFICULDADE";

    void Awake()
    {
        dificuldade = PlayerPrefs.GetInt(keyDificuldade, 0);
    }

    void Start()
    {
        dropdown.value = dificuldade;
        Debug.Log("INICIOU: " + dificuldade);
    }

    public void setDificuldade()
    {
        if (dificuldade != dropdown.value)
        {
            dificuldade = dropdown.value;
            Debug.Log("Alterou: " + dificuldade);

            //salvar um valor no texto dificuldade - cache do pc
            PlayerPrefs.SetInt(keyDificuldade, dificuldade);

            //Resetar a cena
            SceneManager.LoadScene(SceneManager.GetSceneByName("Module5").name);
        }

    }
}