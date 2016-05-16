using UnityEngine;
using System.Collections;
public class Square : MonoBehaviour {
	public string Color;

	/*private Transform target;
	private Transform startline;
	public Transform myTransform;

	private Vector3 firstpos;
	private float duration;


	public float limitSpeed;*/

	public Transform myTransform;

	private Vector2 Destination;
	private Vector2 startPos;

	public float Speed;
	public float limitDuration;
	public float Duration;

	void Awake()
	{
		/*myTransform = transform;*/
		myTransform = transform;
	}

	void Start ()
	{
		/*limitSpeed = 1f;
		duration = 1f;
		firstpos = transform.position;*/
		startPos = transform.position;
		Destination = new Vector2 (transform.position.x, -5.66f);
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
		transform.position = Vector2.Lerp(gameObject.transform.position, Destination, 1/(Duration*(Vector2.Distance(gameObject.transform.position, Destination))));

		if (transform.position.y == Destination.y)
			Destroy (gameObject);
	}
}

