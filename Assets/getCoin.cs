using UnityEngine;
using System.Collections;

//Taken from Aaron Acosta's ReallyBadGame

public class getCoin : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collider)
	{
		Destroy(gameObject);
	}
}
