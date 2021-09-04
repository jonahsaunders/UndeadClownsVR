using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
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
}
