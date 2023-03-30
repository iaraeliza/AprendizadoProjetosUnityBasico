using UnityEngine;

public class PlayerForce : MonoBehaviour
{

	public float velocity = 1;

	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			rb.velocity = Vector2.up * velocity;
		}
	}

	
}



