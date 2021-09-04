using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour 
{
	public GameObject winning;
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			winning.SetActive(true);
			StartCoroutine("restart");
		}
	}
	IEnumerator restart ()
	{
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene("mainmenu");
	}
}

