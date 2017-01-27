using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed;
	public float jump;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		float movehoriontal = Input.GetAxis ("Horizontal");
		Vector2 move = new Vector2(movehoriontal, 0);
		rb.AddForce(move * speed);
		if (Input.GetButtonDown ("Jump") && Grounded) {
			rb.AddForce (Vector2.up * jump);
		}
	}
	bool Grounded;

	void OnCollisionStay2D(Collision2D collider)
	{
		CheckIfGrounded ();
	}

	void OnCollisionExit2D(Collision2D collider)
	{
		Grounded = false;
	}

	private void CheckIfGrounded()
	{
		RaycastHit2D[] hits;

		//We raycast down 1 pixel from this position to check for a collider
		Vector2 positionToCheck = transform.position;
		hits = Physics2D.RaycastAll (positionToCheck, new Vector2 (0, -1), 0.01f);

		//if a collider was hit, we are grounded
		if (hits.Length > 0) {
			Grounded = true;
		}
	}
}
