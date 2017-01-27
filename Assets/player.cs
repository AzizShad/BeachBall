using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed;
	public float jump;
	private int count;
	public Text countText;
	public Text winText;
	public int winCount;
	public int loadScene;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		count = 0;
		winText.text = "";
		SetScoreText ();
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


	//Checks if you hit the ground
	void OnCollisionStay2D(Collision2D collider)
	{
		CheckIfGrounded ();
	}
	//checks if you leave the ground
	void OnCollisionExit2D(Collision2D collider)
	{
		Grounded = false;
	}
	//If on Ground then you jump
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
	//If hit a coin, get a point
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Coin")){
			count++;
			SetScoreText ();
		}
	}
	//brings score onscreen
	void SetScoreText(){
		countText.text = "Score: " + count.ToString ();
		if (count >= winCount) {
			winText.text = "You Win!";
			StartCoroutine (StopSec());
			SceneManager.LoadScene (loadScene);
		}
	}
	//holds for a sec
	IEnumerator StopSec(){
		yield return new WaitForSecondsRealtime (2);
	}
}