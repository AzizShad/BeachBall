using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class respawn : MonoBehaviour {


	//Creating variables
	public Text lives; //Lives Score onscreen
	public GameObject respawnPoint;
	public float RespawnTime; //Delay
	public GameObject player; 
	public int live; //number of lives
	private int liveleft; //lives left
	public Text LivesLeft; //visual representation of lives left
	public int fallHeight; //height at which it respawns you

	// Use this for initialization
	void Start () {
		LivesLeft.enabled = false; //hiding the Lives left text
		liveleft = live; //making lives left equal to lives
		DeathCount (); //putting up lives score onscreen
	}

	void DeathCount(){ //Code to bring lives onscreen
		lives.text = "Lives: " + liveleft.ToString();
	}

	void FixedUpdate(){
		//Code to make sure if player is bellow fallheight he loses a life
		if (player.transform.position.y <= fallHeight) {
			liveleft--;
			if (liveleft <= 0) {
				//Loads Screen (Death Screen)
				SceneManager.LoadScene (8);
			}
			DeathCount();

			//Brings them back to respawn point
			player.transform.position = respawnPoint.transform.position;
			LivesLeft.text = "You Fell\n" + liveleft.ToString() + " Lives Left!";
			StartCoroutine (Wait ());
		}
	}

		
	IEnumerator Wait() { //Brings death count up for RespawnTime amount
		LivesLeft.enabled = true;
		yield return new WaitForSecondsRealtime (RespawnTime);
		LivesLeft.enabled = false;
	}
}
