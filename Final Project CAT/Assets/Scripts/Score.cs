using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int Scores=0;

	private bool flagten = false;
	private bool flaghund = false;
	private bool flagthou = false;
	private bool flagmill = false;

	void Update()
	{
		GameObject score = GameObject.FindGameObjectWithTag ("ScoreText");
		score.GetComponent<TextMesh> ().text = Scores.ToString();

		if (Scores >= 10) {
			if (flagten == false) {
				score.GetComponent<Transform> ().position = new Vector3(-1.4f, score.GetComponent<Transform> ().position.y, score.GetComponent<Transform> ().position.z);
				flagten = true;
			} else {
				if (flaghund == false && Scores >= 100) {
					score.GetComponent<Transform> ().position = new Vector3(-2f, score.GetComponent<Transform> ().position.y, score.GetComponent<Transform> ().position.z);
					flaghund = true;
				} else {
					if (flagthou == false && Scores >= 1000) {
						score.GetComponent<Transform> ().position = new Vector3(-2.8f, score.GetComponent<Transform> ().position.y, score.GetComponent<Transform> ().position.z);
						flagthou = true;
					} else {
						if (flagmill == false && Scores >= 10000) {
							score.GetComponent<Transform> ().position = new Vector3(-3.1f, score.GetComponent<Transform> ().position.y, score.GetComponent<Transform> ().position.z);
							flagmill = true;
						} 
					}
				}
			}
		}

	}
}
