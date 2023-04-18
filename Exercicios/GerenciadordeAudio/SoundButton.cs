using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
	public AudioClip[] sounds;
	private Button[] buttons;
	private AudioSource audioSource;
	private int currentIndex;
	private float currentPlayTime;

	void Start()
	{
		buttons = GetComponentsInChildren<Button>();
		audioSource = GetComponent<AudioSource>();
		currentIndex = -1;

		for (int i = 0; i < buttons.Length; i++)
		{
			int index = i; // necessário para evitar problemas de fechamento (closure)
			buttons[i].onClick.AddListener(() => PlaySound(index));
		}
	}

	void PlaySound(int index)
	{
		if (index == currentIndex)
		{
			// O botão já está selecionado; retomar a reprodução do áudio de onde parou
			audioSource.time = currentPlayTime;
			audioSource.Play();
			return;
		}

		// Parar a reprodução do áudio anterior
		audioSource.Stop();

		// Iniciar a reprodução do novo áudio
		audioSource.clip = sounds[index];
		audioSource.Play();
		currentIndex = index;
		currentPlayTime = 0;
	}

	void Update()
	{
		// Armazenar o tempo atual da música quando ela estiver tocando
		if (audioSource.isPlaying)
		{
			currentPlayTime = audioSource.time;
		}
	}
}
