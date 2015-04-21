using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Rigidbody rb;

	//Use this for init
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	//Update is called once per frame
	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed * Time.deltaTime);

	}
}
