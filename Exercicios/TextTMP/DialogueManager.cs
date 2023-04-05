/*using System.Collections;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI dialogueText;
	public string[] dialogueLines;
	public float letterSpeed = 0.05f;
	private int currentLine = 0;
	private int currentLetter = 0;

	void Start()
	{
		StartCoroutine(ShowText());
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (currentLetter >= dialogueLines[currentLine].Length)
			{
				currentLine++;
				if (currentLine < dialogueLines.Length)
				{
					currentLetter = 0;
					StartCoroutine(ShowText());
				}
				else
				{
					// Fim do diálogo
					dialogueText.text = "";
				}
			}
			else
			{
				currentLetter = dialogueLines[currentLine].Length;
				dialogueText.text = dialogueLines[currentLine];
			}
		}
	}

	IEnumerator ShowText()
	{
		dialogueText.text = "";
		while (currentLetter < dialogueLines[currentLine].Length)
		{
			currentLetter++;
			dialogueText.text = dialogueLines[currentLine].Substring(0, currentLetter);
			yield return new WaitForSeconds(letterSpeed);
		}
	}
}
*/


using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI dialogueText;
	public string[] dialogueLines;
	public float letterSpeed = 0.05f;
	public Image backgroundImage;
	public Sprite[] backgroundImages;
	private int currentLine = 0;
	private string currentText = "";

	void Start()
	{
		StartCoroutine(ShowText());
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			currentLine++;
			if (currentLine < dialogueLines.Length)
			{
				currentText = "";
				StartCoroutine(ShowText());
				if (currentLine < backgroundImages.Length)
				{
					backgroundImage.sprite = backgroundImages[currentLine];
				}
			}
			else
			{
				// Fim do diálogo
				dialogueText.text = "";
				backgroundImage.enabled = false;
			}
		}
	}

	IEnumerator ShowText()
	{
		string line = dialogueLines[currentLine];
		for (int i = 0; i < line.Length; i++)
		{
			currentText += line[i];
			dialogueText.text = $"{currentText}";
			yield return new WaitForSeconds(letterSpeed);
		}
	}
}
