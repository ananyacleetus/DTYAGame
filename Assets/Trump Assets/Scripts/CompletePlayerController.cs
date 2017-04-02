using UnityEngine;
using System.Collections;

public class CompletePlayerController : MonoBehaviour
{
	public float speed = 1f;

	void Start() {
		
	}

	void Update ()
	{
		if (Rigidbody2D. > 0f) {
			transform.position -= new Vector3 (0.0f, 20.0f * Time.deltaTime, 0.0f);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3 (0.0f, speed * Time.deltaTime * 15, 0.0f);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			if (transform.position.y > 0f) {
				transform.position -= new Vector3 (0.0f, speed * Time.deltaTime, 0.0f);
			}
		}
	}
}