using UnityEngine;
using System.Collections;

public class GlobalProperties : MonoBehaviour {
	public int currentGroup;
	public GameObject currentSquare;
	public GameObject ball;

	public Vector3 changePos()
	{
		if (currentGroup > 0) {
			return  new Vector3 (currentSquare.transform.position.x+(currentSquare.GetComponent<Square>().getWidth()/10),
				currentSquare.transform.position.y+0.5f, 
				ball.GetComponent<BallTeleportSimple>().transform.position.z);
		}return ball.transform.position;
	}

	public bool keepPlaying ()
	{
		if (currentGroup > 0) {
			if (ball.GetComponent<BallName> ().ColorP.Equals (currentSquare.GetComponent<Square> ().Color)) {
				return true;
			} else
				return false;
		} else
			return true;
	}
}
