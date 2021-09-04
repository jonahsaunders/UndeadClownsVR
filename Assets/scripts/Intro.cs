using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
	public void StartScreen (string sceneName)
	{
		Application.LoadLevel("game");
	}
	public void QuitScreen (string quit)
	{
		Application.Quit();
	}
	public void ToStartScreen (string start)
	{
		Application.LoadLevel("mainmenu");
	}
	public void Tutorial (string skip)
	{
		Application.LoadLevel("tutorial");
	}
	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Alpha1)) {
			Application.LoadLevel ("game");
		}
		if (Input.GetKeyUp (KeyCode.Alpha2)) {
			Application.LoadLevel ("tutorial");
		}
		if (Input.GetKeyUp (KeyCode.Alpha3)) {
			Application.Quit ();
		}
	}
}
