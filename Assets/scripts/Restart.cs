using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour 
{

	void Start () 
	{
		StartCoroutine("Redo");
	}
	IEnumerator Redo ()
	{
		yield return new WaitForSeconds(5);
		Application.LoadLevel("mainmenu");
	}
}
