using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gotoscene : MonoBehaviour {

	public Canvas continueCan;
	public Button continueButton;
	public int sceneNum;

	//Leave screen to new scene
	void Start(){
		continueCan = continueCan.GetComponent<Canvas> ();
		continueButton = continueButton.GetComponent<Button> ();
	}

	public void GoToScene(){
		SceneManager.LoadScene (sceneNum);
	}
}
