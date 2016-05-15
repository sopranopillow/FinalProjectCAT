using UnityEngine;
using System.Collections;
public class Square : MonoBehaviour {
	public string Color;

	private Transform target;
	private Transform startline;
	public Transform myTransform;

	private Vector3 firstpos;
	private float duration;

		void Awake()
		{
			myTransform = transform;
			
		}

		void Start ()
		{
		duration = 2f;
		firstpos = transform.position;
		}

		void Update () {
		transform.position = Vector3.MoveTowards(transform.position, new Vector3 (transform.position.x, -5.66f, 0f), Time.deltaTime*duration);
		if (transform.position == new Vector3 (transform.position.x, -5.66f, 0f)) {
			transform.position = new Vector3 (transform.position.x, 6f, 0f);
		}

		}
}
