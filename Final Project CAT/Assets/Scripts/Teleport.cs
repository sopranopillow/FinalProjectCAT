using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	private bool click = false; 

	private Vector2 destination;

	public float duration = 5.0f;

	private float yAxis;

	private float defaultPosition;

	public Camera cam;

	public float velocity;

	// Use this for initialization
	void Start () {
		yAxis = gameObject.transform.position.y;
		defaultPosition = gameObject.transform.position.x;
	}
	
	//Set up a variable to access the player from
	//private Transform player; 

	void Awake()
	{
		//Find the player object and set it
		//player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update()
	{
		// Check if you click the left mouse button then change position
		//if (Input.GetMouseButtonDown(0))
		//	player.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		//check if the screen is touched / clicked   
		if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown(0)))
		{
			//declare a variable of RaycastHit struct
			RaycastHit hit;
			//Create a Ray on the tapped / clicked position
			Ray ray;
			//for unity editor
			#if UNITY_EDITOR
			ray = cam.ScreenPointToRay(Input.mousePosition);
			//for touch device
			#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
			ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			#endif

			//Check if the ray hits any collider
			if(Physics.Raycast(ray,out hit))
			{
				//set a click to indicate to move the gameobject
				click = true;
				//save the click / tap position
				destination = hit.point;
				//as we do not want to change the y axis value based on touch position, reset it to original y axis value
				//destination.y = yAxis;
				Debug.Log(destination);
			}

		}
		//check if the click for movement is true and the current gameobject position is not same as the clicked / tapped position
		if(click && !Mathf.Approximately(gameObject.transform.position.magnitude, destination.magnitude)){ //&& !(V3Equal(transform.position, destination))){
			//gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, destination, velocity); 
			//move the gameobject to the desired position
			gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, destination, 1/(duration*(Vector2.Distance(gameObject.transform.position, destination))));
		}
		//set the movement indicator click to false if the destination and current gameobject position are equal
		else if(click && Mathf.Approximately(gameObject.transform.position.magnitude, destination.magnitude)) {
			click = false;
			Debug.Log("Whas poppin ma nigga");
		}
	}
}