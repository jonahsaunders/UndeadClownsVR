using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
	public GameObject battery;
	public GameObject batterytwo;
	public GameObject batterythree;

	public GameObject flashlight;

	public AudioClip click;

	public AudioSource source;

	public float energy;
	//max battery is equal to 9

	private float vol;

	public bool usingpower;

	public bool toggle;

	public bool stunable;

	public GameObject shield;

	void Start () 
	{
		StartCoroutine("Recharge");
		flashlight.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (energy > 9)
		{
			energy = 9;
		}
		if (energy <= 6)
		{
			battery.SetActive(false);
		}
		else
		{
			battery.SetActive(true);
		}	
		if (energy <= 3)
		{
			batterytwo.SetActive(false);
		}
		else
		{
			batterytwo.SetActive(true);
		}	
		if (energy <= 0)
		{
			batterythree.SetActive(false);
			flashlight.SetActive(false);
			energy = 0;
			usingpower = false;
		}
		else
		{
			batterythree.SetActive(true);
		}	
		if (Input.GetKeyUp(KeyCode.F))
		{
			if (!(toggle))
			{
				toggle = true;
				usingpower = true;
				StartCoroutine("Energy");
				Debug.Log("Toggleon");
				flashlight.SetActive(true);
				float vol = Random.Range (1, 2);
				source.PlayOneShot(click, vol);
				if (stunable)
				{
					StartCoroutine("Stun");
				}

			}
			else if (toggle)
			{
				usingpower = false;
				flashlight.SetActive(false);
				Debug.Log("Toggleoff");
				toggle = false;
			}
		}
	}
	IEnumerator Recharge ()
	{
		yield return new WaitForSeconds(1);
		energy += 1;
		StartCoroutine("Recharge");
	}
	IEnumerator Energy ()
	{
		yield return new WaitForSeconds(1);
		energy -= 2;
		Debug.Log("Energy");
		StartCoroutine("check");
	}
	IEnumerator check ()
	{
		if (usingpower)
		{
			Debug.Log("Check");
			yield return new WaitForSeconds(1);
			energy -= 2;
			StartCoroutine("check");
		}
	}
	IEnumerator Stun ()
	{
		shield.SetActive(true);
		yield return new WaitForSeconds(4);
		shield.SetActive(false);
	}

}
