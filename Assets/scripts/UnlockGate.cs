using UnityEngine;
using System.Collections;

public class UnlockGate : MonoBehaviour
{
	public GameObject gateone;
	public GameObject gatetwo;
	public GameObject gatethree;
	public GameObject gatefour;

	public float whichgate;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			whichgate = Random.Range(0,5);
			if (whichgate == 1)
			{
				Destroy(gateone);
				Destroy(this.gameObject);
			}
			if (whichgate == 2)
			{
				Destroy(gatetwo);
				Destroy(this.gameObject);
			}
			if (whichgate == 3)
			{
				Destroy(gatethree);
				Destroy(this.gameObject);
			}
			if (whichgate == 4)
			{
				Destroy(gatefour);
				Destroy(this.gameObject);
			}
		}
	}
}
