using TMPro;
using UnityEngine;

public class MovingText : MonoBehaviour
{
	public float speed = 1f;
	public float amplitude = 0.5f;

	private float startTime;
	private Vector3 initialPosition;
	private TextMeshProUGUI text;

	void Start()
	{
		startTime = Time.time;
		initialPosition = transform.position;
		text = GetComponent<TextMeshProUGUI>();
	}

	void FixedUpdate()
	{
		float t = Time.time - startTime;
		float yOffset = amplitude * Mathf.Sin(speed * t);

		Vector3 newPosition = initialPosition + new Vector3(0f, yOffset, 0f);
		transform.position = newPosition;

		text.ForceMeshUpdate();
	}
}
