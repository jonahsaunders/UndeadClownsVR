using UnityEngine;
using System.Collections;

public class teleportshield : MonoBehaviour 
{

	public GameObject[] pads;
	public int index;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "clown")
		{
			index = Random.Range (0, 11);
			other.gameObject.transform.position = pads[index].transform.position;
		}
	}

}
