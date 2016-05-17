using UnityEngine;
using System.Collections;

public class BallTeleportSimple : MonoBehaviour {

	Vector3 newPosition;


	void Start(){
		newPosition = transform.position;
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				newPosition = new Vector3(hit.point.x, hit.point.y, -0.5f);
				transform.position = newPosition;
			}
		}
	}

}
