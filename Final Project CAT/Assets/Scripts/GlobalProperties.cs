using UnityEngine;
using System.Collections;

public class GlobalProperties : MonoBehaviour {
	public int currentGroup;
	public GameObject currentSquare;
	public GameObject ball;

	public void changePos()
	{
		if (currentGroup > 0) {
			ball.transform.position = new Vector3 (ball.GetComponent<BallTeleportSimple>().transform.position.x, currentSquare.transform.position.y+0.5f, ball.GetComponent<BallTeleportSimple>().transform.position.z);
		}
	}
}
