using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Menu : MonoBehaviour 
{

	public bool onoffswitch;
	public float tester;
	public GameObject Quit;
	public GameObject hard;
	public GameObject hardcheck;
	public GameObject medium;
	public GameObject mediumcheck;
	public GameObject easy;
	public GameObject easycheck;



	public float level;


	void Start ()
	{
		level = 1;
	}
	public void ChangeEasy (string skipeasy)
	{
		level = 1;
		GameObject.Find("clown").GetComponent<Enemy>().speedof = 7;
		GameObject.Find("sad").GetComponent<Enemy>().speedof = 2;
		GameObject.Find("tper").GetComponent<Enemy>().speedof = 7;
		GameObject.Find("teleport").GetComponent<Enemy>().speedof = 2;
		GameObject.Find("runner").GetComponent<Enemy>().speedof = 10;
		GameObject.Find("FPSController").GetComponent<Flashlight>().stunable = false;
		Debug.Log("easy");
	}
	public void ChangeMedium (string skipmedium)
	{
		level = 2;
		GameObject.Find("clown").GetComponent<Enemy>().speedof = 9;
		GameObject.Find("sad").GetComponent<Enemy>().speedof = 4;
		GameObject.Find("tper").GetComponent<Enemy>().speedof = 9;
		GameObject.Find("teleport").GetComponent<Enemy>().speedof = 4;
		GameObject.Find("runner").GetComponent<Enemy>().speedof = 12;
		GameObject.Find("FPSController").GetComponent<Flashlight>().stunable = true;
		Debug.Log("easy");
	}
	public void ChangeHard (string skiphard)
	{
		level = 3;
		GameObject.Find("clown").GetComponent<Enemy>().speedof = 14;
		GameObject.Find("sad").GetComponent<Enemy>().speedof = 4;
		GameObject.Find("tper").GetComponent<Enemy>().speedof = 11;
		GameObject.Find("teleport").GetComponent<Enemy>().speedof = 8;
		GameObject.Find("runner").GetComponent<Enemy>().speedof = 16;
		GameObject.Find("FPSController").GetComponent<Flashlight>().stunable = true;
		Debug.Log("easy");
	}
	void Update ()
	{
		if (Input.GetKeyUp(KeyCode.Alpha1))
		{
			level = 1;
			GameObject.Find("clown").GetComponent<Enemy>().speedof = 7;
			GameObject.Find("sad").GetComponent<Enemy>().speedof = 2;
			GameObject.Find("tper").GetComponent<Enemy>().speedof = 7;
			GameObject.Find("teleport").GetComponent<Enemy>().speedof = 2;
			GameObject.Find("runner").GetComponent<Enemy>().speedof = 10;
			GameObject.Find("FPSController").GetComponent<Flashlight>().stunable = false;
			Debug.Log("easy");
		}
		if (Input.GetKeyUp(KeyCode.Alpha2))
		{
			level = 2;
			GameObject.Find("clown").GetComponent<Enemy>().speedof = 9;
			GameObject.Find("sad").GetComponent<Enemy>().speedof = 4;
			GameObject.Find("tper").GetComponent<Enemy>().speedof = 9;
			GameObject.Find("teleport").GetComponent<Enemy>().speedof = 4;
			GameObject.Find("runner").GetComponent<Enemy>().speedof = 12;
			GameObject.Find("FPSController").GetComponent<Flashlight>().stunable = true;
			Debug.Log("easy");
		}
		if (Input.GetKeyUp(KeyCode.Alpha3))
		{
			level = 3;
			GameObject.Find("clown").GetComponent<Enemy>().speedof = 14;
			GameObject.Find("sad").GetComponent<Enemy>().speedof = 4;
			GameObject.Find("tper").GetComponent<Enemy>().speedof = 11;
			GameObject.Find("teleport").GetComponent<Enemy>().speedof = 8;
			GameObject.Find("runner").GetComponent<Enemy>().speedof = 16;
			GameObject.Find("FPSController").GetComponent<Flashlight>().stunable = true;
			Debug.Log("easy");
		}
		if (Input.GetKeyUp(KeyCode.Alpha4))
		{
			Application.Quit();
		}
		if (Input.GetKeyUp(KeyCode.Alpha0))
		{
			Application.Quit();
		}
		
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			Debug.Log("Escape pressed");
			if (!(onoffswitch)) 
			{
				onoffswitch = true;
				tester = 2;
			} 
			else if (onoffswitch) {
				onoffswitch = false;
				tester = 4;
			}
		}
		if (onoffswitch)
		{
			Quit.SetActive(false);
			hard.SetActive(false);
			medium.SetActive(false);
			easy.SetActive(false);

		}
		if (!(onoffswitch))
		{
			Quit.SetActive(true);
			Quit.SetActive(true);
			hard.SetActive(true);
			medium.SetActive(true);
			easy.SetActive(true);

			if(level == 1)
			{
				easycheck.SetActive(true);
			}
			else
			{
				easycheck.SetActive(false);
			}
			if(level == 2)
			{
				mediumcheck.SetActive(true);
			}
			else
			{
				mediumcheck.SetActive(false);
			}
			if(level == 3)
			{
				hardcheck.SetActive(true);
			}
			else
			{
				hardcheck.SetActive(false);
			}
		}
			
	}
}
