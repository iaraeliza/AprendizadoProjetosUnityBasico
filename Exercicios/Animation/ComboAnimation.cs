using UnityEngine;

public class ComboAnimation : MonoBehaviour
{
	private Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator>();
	}

	private void OnMouseDown()
	{
		anim.SetTrigger("MudarEstado");
	}
}
