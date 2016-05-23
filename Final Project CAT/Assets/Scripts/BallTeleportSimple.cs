using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BallTeleportSimple : MonoBehaviour {

	Vector3 newPosition= new Vector3(0f, -5f, 0f);
	Vector3 defpos;

	public Sprite[] PTextures;

	public Camera cam;

	public bool checktele=false;
	public bool playercrush=true;

	void Start(){
		defpos= transform.position;
	}

	void Update(){
			//References BallName
			GameObject ball = GameObject.FindGameObjectWithTag ("Player");
			BallName nameb = ball.GetComponent<BallName> ();
			string Ballcolorstring = nameb.ColorP;


			//References ColorChangePlayer
			ColorChangePlayer changecol = ball.GetComponent<ColorChangePlayer> ();


			//References Square
			GameObject square = GameObject.FindGameObjectWithTag ("Obstacle");
			Square namesq = square.GetComponent<Square> ();
			string Squarecolorstring = namesq.Color;
			Vector3 Squarepos = namesq.myTransform.position;

			//Checking Purposes
			/*Debug.Log (Ballcolorstring.Equals (Squarecolorstring));
			Debug.Log (Ballcolorstring);
			Debug.Log (Squarecolorstring);*/

			//Mouse Click
			if (Input.GetMouseButtonDown (0)) {
				checktele = true;

				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
	
			if (hit.collider.isTrigger &&(hit.collider.gameObject.GetComponent<Square>().Groups==cam.GetComponent<GlobalProperties>().currentGroup+1)) {
					newPosition = new Vector3 (hit.collider.transform.position.x, hit.collider.transform.position.y + 0.1f, 0f);
					//gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, newPosition, 2f*Time.deltaTime);
					//transform.position = Vector3.Lerp(transform.position, newPosition, 5*Time.deltaTime) ;

					cam.GetComponent<GlobalProperties> ().currentGroup = hit.collider.gameObject.GetComponent<Square> ().Groups;
					cam.GetComponent<GlobalProperties> ().currentSquare = hit.collider.gameObject;
					
				GameObject[] objects = GameObject.FindGameObjectsWithTag ("Obstacle");
				List<GameObject> lines = new List<GameObject> ();

				int count = 0;
				for (int i = 0; i < objects.Length; i++) {
					if (objects [i].GetComponent<Square> ().Groups == cam.GetComponent<GlobalProperties> ().currentGroup + 1) {
						lines.Add(objects[i]);
						count++;
					}
				}

				int ran = Random.Range (0,lines.Count);
					

				if (hit.collider.gameObject.GetComponent<Square> ().Color == ball.GetComponent<BallName> ().ColorP) {
					GameObject score = GameObject.FindGameObjectWithTag ("ScoreText");
					score.GetComponent<Score> ().Scores += 1;
				} else {
					//QuitApplication quit = new QuitApplication ();
					//quit.Quit ();//Se supone que aqui va GameOverScene.Load();
					DoGO();
				}

				changecol.changecolors (PTextures, lines[ran].GetComponent<Square>().Color);
				}
			}

			//Smooth Movement
			if (checktele == true) {
				transform.position = Vector3.MoveTowards (transform.position, newPosition /*square.transform.position*/, 35 * Time.deltaTime);
			}

			if (transform.position.y < -5.1)
			{
			DoGO ();
			//	QuitApplication quit = new QuitApplication ();
			//	quit.Quit ();//Se supone que aqui va GameOverScene.Load();
			}


			/*Debug.Log (square.transform.position.y);
			Debug.Log (transform.position.y);
			Debug.Log (defpos.y);*/

			if (transform.position.y.Equals(defpos.y)) {
				if (square.transform.position.y < transform.position.y) {
				DoGO ();
				}
			}

			newPosition = cam.GetComponent<GlobalProperties> ().changePos ();
	}

	public void DoGO()
	{
		ShowGameOver.showGameOver ();
	}
}
