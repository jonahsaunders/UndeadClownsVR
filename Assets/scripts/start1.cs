using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start1 : MonoBehaviour 
{

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Alpha1))
		{
			Application.LoadLevel ("game");
		}
	}
}
