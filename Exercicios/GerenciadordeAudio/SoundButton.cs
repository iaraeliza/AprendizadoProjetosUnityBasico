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
			int index = i; // necess�rio para evitar problemas de fechamento (closure)
			buttons[i].onClick.AddListener(() => PlaySound(index));
		}
	}

	void PlaySound(int index)
	{
		if (index == currentIndex)
		{
			// O bot�o j� est� selecionado; retomar a reprodu��o do �udio de onde parou
			audioSource.time = currentPlayTime;
			audioSource.Play();
			return;
		}

		// Parar a reprodu��o do �udio anterior
		audioSource.Stop();

		// Iniciar a reprodu��o do novo �udio
		audioSource.clip = sounds[index];
		audioSource.Play();
		currentIndex = index;
		currentPlayTime = 0;
	}

	void Update()
	{
		// Armazenar o tempo atual da m�sica quando ela estiver tocando
		if (audioSource.isPlaying)
		{
			currentPlayTime = audioSource.time;
		}
	}
}
