using UnityEngine;
using System.Collections;

public class ScrollingB : MonoBehaviour {

	public float limitSpeed = 1.5f;
	public float speed = 0.001f;
	
	public GameObject square_1;
	public GameObject square_2;
	public GameObject square_3;
	public GameObject square_4;
	public GameObject square_5;
	public GameObject square_6;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2 (0, Time.time * (speed));
		if(speed<limitSpeed)
			speed+=0.00009f;
		//Console.writeLine(speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
