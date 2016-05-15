using UnityEngine;
using System.Collections;
public class Square : MonoBehaviour {
	public string Color;

	private Transform target;
	private Transform startline;
	public Transform myTransform;

	private Vector3 firstpos;
	private float duration;

	private float limitSpeed;

		void Awake()
		{
			myTransform = transform;
			
		}

		void Start ()
		{
		limitSpeed = 10f;
		duration = 1f;
		firstpos = transform.position;
		}

		void Update () {
		transform.position = Vector3.MoveTowards(transform.position, new Vector3 (transform.position.x, -5.66f, 0f), Time.deltaTime*duration);

			//Restart Loop
			if (transform.position == new Vector3 (transform.position.x, -5.66f, 0f)) {
				transform.position = new Vector3 (transform.position.x, 6.4f, 0f);
				//Destroy(gameObject);
			}

			//Speed
			if (duration < limitSpeed) {
				duration += .008f;
			}

		}
}
