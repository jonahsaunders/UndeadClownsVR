using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	public GameObject player;
	public GameObject trackerone;
	public GameObject trackertwo;
	public GameObject trackerthree;
	public GameObject trackerfour;
	public GameObject trackerfive;
	public GameObject map;
	public GameObject key;

	public GameObject battery;
	public GameObject batterytwo;
	public GameObject batterythree;
	public GameObject batteryfour;
	public GameObject batteryfive;

	public float batterypower;

	public bool toggle;
	public bool usingpower;

	void Start ()
	{
		StartCoroutine("Recharge");
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.M))
		{
			if (!(toggle) && batterypower > 0)
			{
				toggle = true;
				Debug.Log("Toggleonmap");
				player.SetActive(false);
				key.SetActive(false);
				map.SetActive(true);
				trackerone.SetActive(true);
				trackertwo.SetActive(true);
				trackerthree.SetActive(true);
				trackerfour.SetActive(true);
				trackerfive.SetActive(true);
				Time.timeScale = 0.2F;
			}
			else if (toggle)
			{
				player.SetActive(true);
				map.SetActive(false);
				key.SetActive(true);
				Debug.Log("Toggleoffmap");
				toggle = false;
				Time.timeScale = 1.0F;
				trackerone.SetActive(false);
				trackertwo.SetActive(false);
				trackerthree.SetActive(false);
				trackerfour.SetActive(false);
				trackerfive.SetActive(false);
			}
		}
	}
}
