using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//Taken from Xenosmash Games video tutorial
//Brings menu screen up 
public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas creditMenu;
	public Button start;
	public Button exit;
	public Button credit;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		start = start.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
		quitMenu.enabled = false;
		creditMenu.enabled = false;
	}

	//Brings up quit menu up holds the rest
	public void ExitPress(){
		quitMenu.enabled = true;
		start.enabled = false;
		credit.enabled = false;
		exit.enabled = false;
	}

	//Brings up Credit menu holds the rest
	public void CreditPress(){
		creditMenu.enabled = true;
		start.enabled = false;
		credit.enabled = false;
		exit.enabled = false;
	}

	//brings everything back to normal
	public void NoPress(){
		quitMenu.enabled = false;
		creditMenu.enabled = false;
		start.enabled = true;
		credit.enabled = true;
		exit.enabled = true;
	}

	public void ExitGame(){
		Application.Quit ();
	}

	//leaves game
	public void StartGame(){
		SceneManager.LoadScene (5);
	}


}
