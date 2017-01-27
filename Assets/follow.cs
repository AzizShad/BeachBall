using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	private Vector2 vel;
	public float smoothY;
	public float smoothX;

	//Taken from Xenosmash Games video tutorial

	//Make sures to follow script
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref vel.x, smoothX);
		float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref vel.y, smoothY);
		
		transform.position = new Vector3 (posX, posY, transform.position.z);
	}
}
