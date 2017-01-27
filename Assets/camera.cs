// This Script was taken from the Unity Tutorials on their Website


using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	//Creating Variables to set
	private Vector3 offset;
	public GameObject player;

	// Use this for initialization
	void Start () {
		//setting offset
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//Moving Camera
		transform.position = player.transform.position + offset;
	}
}
