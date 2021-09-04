using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

	public Transform player;
	public GameObject playerobj;
	public Transform thisobject;
	public bool enemyCanSee;

	public bool toggle;

	public float speedof;
	public float range;

	public float update;



	UnityEngine.AI.NavMeshAgent agent;

	public stateMachine state;

	public enum stateMachine
	{
		idle,
		following,
	}
	void Awake ()
	{
		playerobj = GameObject.FindGameObjectWithTag("Player");
		player = playerobj.transform;

		thisobject = this.transform;
	}
	void Start ()
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}


	void FixedUpdate()
	{
		if (state == stateMachine.following)
		{
			if (!(toggle))
			{
				toggle = true;
				StartCoroutine("following");
			}
		}
		DetectPlayer();
	}

	IEnumerator following ()
	{
		agent.SetDestination(player.position);
		yield return new WaitForSeconds(update);
		toggle = false;

	}
	public void DetectPlayer ()
	{
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Vector3.Distance(player.position, thisobject.position) < range)
		{
			GetComponent<UnityEngine.AI.NavMeshAgent>().speed = speedof;

			state = stateMachine.following;
		}
		else
		{
			state = stateMachine.idle;
		}
	}
}