using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Script to bring up exit screen and go back to main menu
public class exitscript : MonoBehaviour {

	public Canvas quitMenu;
	public Button exit;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		exit = exit.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	//brings up quit menu
	public void ExitPress(){
		quitMenu.enabled = true;
		exit.enabled = false;
	}
	//exits quit menu
	public void NoPress(){
		quitMenu.enabled = false;
		exit.enabled = true;
	}
	//exits game
	public void ExitGame(){
		SceneManager.LoadScene (0);
	}
}

