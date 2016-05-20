using UnityEngine;
using System.Collections;

public class BallTeleportSimple : MonoBehaviour {

	Vector3 newPosition= new Vector3(0f, -5f, 0f);

	public Sprite[] PTextures;

	public bool checktele=false;

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
			checktele = true;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
	
			if (hit.collider.isTrigger/*&&(Ballcolorstring.Equals(Squarecolorstring)==true)*/) {
				newPosition= new Vector3(hit.collider.transform.position.x,hit.collider.transform.position.y+0.1f, 0f);
				//gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, newPosition, 2f*Time.deltaTime);
				//transform.position = Vector3.Lerp(transform.position, newPosition, 5*Time.deltaTime) ;
				changecol.changecolor(PTextures);
				GameObject score = GameObject.FindGameObjectWithTag ("ScoreText");
				score.GetComponent<Score> ().Scores += 1;
			}
		}

		//Smooth Movement
		if (checktele == true) {
			transform.position = Vector3.MoveTowards (transform.position,newPosition /*square.transform.position*/, 50 * Time.deltaTime);
		}
	}

}
