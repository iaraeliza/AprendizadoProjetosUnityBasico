using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListaDeEnigmas : MonoBehaviour
{
	[SerializeField]  public List<Enigma> listaDeEnigmas = new List<Enigma>();
	[SerializeField]  public List<Enigma> listaDeEnigmasMedio = new List<Enigma>();
	[SerializeField]  public List<Enigma> listaDeEnigmasDificil = new List<Enigma>();
}
