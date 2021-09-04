using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScaryClowns : MonoBehaviour
{
	public GameObject clownone;
	public GameObject clowntwo;
	public GameObject clownthree;
	public GameObject clownfour;

	public GameObject quit;

	public float pickclown;

	public AudioClip scream;

	public AudioSource source;

	void Start ()
	{
		pickclown = 0;
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("Hit clown");
			pickclown = Random.Range(0,5);
			if (pickclown == 1)
			{
				clownone.SetActive(true);
				quit.SetActive(true);
				float vol = Random.Range (1, 2);
				source.PlayOneShot(scream, vol);
				StartCoroutine("Redo");
			}
			if (pickclown == 2)
			{
				clowntwo.SetActive(true);
				quit.SetActive(true);
				float vol = Random.Range (1, 2);
				source.PlayOneShot(scream, vol);
				StartCoroutine("Redo");
			}
			if (pickclown == 3)
			{
				clownthree.SetActive(true);
				quit.SetActive(true);
				float vol = Random.Range (1, 2);
				source.PlayOneShot(scream, vol);
				StartCoroutine("Redo");
			}
			if (pickclown == 4)
			{
				clownfour.SetActive(true);
				quit.SetActive(true);
				float vol = Random.Range (1, 2);
				source.PlayOneShot(scream, vol);
				StartCoroutine("Redo");
			}
		}
	}
	IEnumerator Redo ()
	{
		yield return new WaitForSeconds(5);
		Application.LoadLevel("mainmenu");
	}
}
