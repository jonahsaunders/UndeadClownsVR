using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour 
{
	public GameObject[] keys;
	public int index;

	void Start () 
	{
		index = Random.Range (0, 19);
		keys[index].SetActive(true);
		GameObject.Find("Canvas").GetComponent<Map>().key = keys[index];
	}	
}
