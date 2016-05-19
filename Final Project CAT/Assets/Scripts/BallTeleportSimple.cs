using UnityEngine;
using System.Collections;

public class BallTeleportSimple : MonoBehaviour {

	Vector3 newPosition;

	public Sprite[] PTextures;


	void Start(){
	}

	void Update(){

		//References BallName
		GameObject ball = GameObject.FindGameObjectWithTag ("Player");
		BallName nameb= ball.GetComponent<BallName>();
		string Ballcolorstring= nameb.ColorP;


		//References ColorChangePlayer
		ColorChangePlayer changecol = ball.GetComponent<ColorChangePlayer>();


		//References Square
		GameObject square = GameObject.FindGameObjectWithTag ("Obstacle");
		Square namesq= square.GetComponent<Square>();
		string Squarecolorstring = namesq.Color;
		Vector3 Squarepos = namesq.myTransform.position;

		//Checking Purposes
		Debug.Log(Ballcolorstring.Equals(Squarecolorstring));
		Debug.Log(Ballcolorstring);
		Debug.Log(Squarecolorstring);

		//Mouse Click
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
	
			if (hit.collider.isTrigger/*&&(Ballcolor.Equals(Squarecolor)==true)*/) {
				newPosition= new Vector3(hit.collider.transform.position.x,hit.collider.transform.position.y+0.2f, 0f);
				//newPosition = new Vector3 (Squarepos.x,Squarepos.y+.2f,0f);
				transform.position = newPosition;
				changecol.changecolor(PTextures);
			}
		}
	}
		

}
