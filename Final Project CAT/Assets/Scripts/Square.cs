using UnityEngine;
using System.Collections;
public class Square : MonoBehaviour {
	public string Color;

	private Transform target;
	private Transform startline;
	public Transform myTransform;

	private Vector3 firstpos;
	public float duration;

	public float speed;//0.008

	public float limitSpeed;

	void Awake()
	{
		myTransform = transform;
			
	}

	void Start ()
	{
		limitSpeed = 1f;
		duration = GameObject.FindGameObjectWithTag ("Background").GetComponent<ScrollingB>().speed;
		firstpos = transform.position;
	}

	void Update () 
	{
		transform.position = Vector3.MoveTowards(transform.position, new Vector3 (transform.position.x, -5.66f, 0f), Time.deltaTime*duration);

		//Restart Loop
		if (transform.position == new Vector3 (transform.position.x, -5.66f, 0f)) {
			//transform.position = new Vector3 (transform.position.x, 6.4f, 0f);
			Destroy(gameObject);
		}

		//Speed
		if (duration < limitSpeed) {
			duration += 0.008f;
		}
	}
}
