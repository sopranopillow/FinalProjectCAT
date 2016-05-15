using UnityEngine;
using System.Collections;

public class ScrollingB : MonoBehaviour {

	public float limitSpeed = 1.5f;
	public float speed = 0.001f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2 (0, Time.time * (speed));
		if(speed<limitSpeed)
			speed+=0.00009f;
		
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
