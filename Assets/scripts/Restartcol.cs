using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartcol : MonoBehaviour
{

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "clown")
		{
				StartCoroutine("Redo");
		}
	}
	IEnumerator Redo ()
	{
		yield return new WaitForSeconds(4);
		Application.LoadLevel("mainmenu");
	}
}
