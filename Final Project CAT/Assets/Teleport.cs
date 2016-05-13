using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	//Set up a variable to access the player from
	private Transform player; 

	void Awake()
	{
		//Find the player object and set it
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update()
	{
		// Check if you click the left mouse button then change position
		if (Input.GetMouseButtonDown(0))
			player.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
}