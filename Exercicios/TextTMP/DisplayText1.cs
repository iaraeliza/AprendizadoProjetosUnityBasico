using System.Collections;
using TMPro;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI textMeshPro;
	[SerializeField] private float speed = 0.1f;

	private string fullText;
	private Coroutine coroutine;

	private void Start()
	{
		fullText = textMeshPro.text;
		textMeshPro.text = "";
		coroutine = StartCoroutine(DisplayTextCoroutine());
	}

	private IEnumerator DisplayTextCoroutine()
	{
		for (int i = 0; i < fullText.Length; i++)
		{
			textMeshPro.text += fullText[i];
			yield return new WaitForSeconds(speed);
		}
	}

	public void SetSpeed(float value)
	{
		speed = value;
		StopCoroutine(coroutine);
		coroutine = StartCoroutine(DisplayTextCoroutine());
	}
}
