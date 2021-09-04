using UnityEngine;
using System.Collections;

public class teleporting : MonoBehaviour 
{

	public GameObject[] pads;
	public int index;


	public float timetoteleport;

	void Start ()
	{
		StartCoroutine("Teleport");
	}
	IEnumerator Teleport ()
	{
		index = Random.Range (0, 11);
		yield return new WaitForSeconds(timetoteleport);
		this.gameObject.transform.position = pads[index].transform.position;
		StartCoroutine("Teleport");
	}

	

}
