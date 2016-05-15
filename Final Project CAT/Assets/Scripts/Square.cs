using UnityEngine;
using System.Collections;
public class Square : MonoBehaviour {
	public string Color;

	private Transform target;
	private Transform startline;
	public Transform myTransform;

	private float duration;

		void Awake()
		{
			myTransform = transform;
		}

		void Start ()
		{
		duration = .5f;
		Vector3 startline = new Vector3 (transform.position.x, transform.position.y, 0f);
		Vector3 target = new Vector3 (transform.position.x, -5.66f, 0f);

		}

		void Update () {
		transform.position = Vector3.Lerp(startline.position, target.position, Time.deltaTime/duration);
		}
		
}
