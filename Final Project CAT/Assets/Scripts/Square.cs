﻿using UnityEngine;
using System.Collections;
public class Square : MonoBehaviour {
	public string Color;

	public bool Coin;

	/*private Transform target;
	private Transform startline;
	public Transform myTransform;

	private Vector3 firstpos;
	private float duration;


	public float limitSpeed;*/

	public Transform myTransform;

	private Vector3 Destination;
	private Vector3 startPos;

	public float Speed;
	public float limitDuration;
	public float Duration;
	public int Division;

	public int Groups;

	private float width;

	void Awake()
	{
		/*myTransform = transform;*/
		myTransform = transform;
	}

	public float getWidth()
	{
		return width;
	}

	public void setWidth(float wid)
	{
		width = wid;
	}

	void Start ()
	{
		/*limitSpeed = 1f;
		duration = 1f;
		firstpos = transform.position;*/
		startPos = transform.position;
		Destination = new Vector3 (transform.position.x, -7.5f);
	}

	void Update () {
		/*transform.position = Vector3.MoveTowards(transform.position, new Vector3 (transform.position.x, -5.66f, 0f), Time.deltaTime*duration);

		//Restart Loop
		if (transform.position == new Vector3 (transform.position.x, -5.66f, 0f)) {
			//transform.position = new Vector3 (transform.position.x, 6.4f, 0f);
			Destroy(gameObject);
		}

		//Speed
		if (duration < limitSpeed) {
			duration += .008f;
		}*/
		transform.position = Vector3.Lerp(gameObject.transform.position, Destination, 1/(Duration*(Vector3.Distance(gameObject.transform.position, Destination))));

		if (transform.position.y == Destination.y)
			Destroy (gameObject);
	}
}

