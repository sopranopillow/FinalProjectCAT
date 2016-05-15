using UnityEngine;
using System.Collections;

public class BoxCreation : MonoBehaviour {

	public Sprite[] Default;

	public GameObject prefab_2;
	public GameObject prefab_3;
	public GameObject prefab_4;
	public GameObject prefab_5;
	public GameObject prefab_6;

	public float x;
	public float y;

	int[] acolor = new int [6];

	int acount=0;
		
	void Start ()
	{
		//Sets array to -1s
		//------------------
		for (int o = 0; o < acolor.Length; o++) {
			acolor [o] = -1;
		}
		//-----------------

		MakeLine (2);
	}
		


	public void MakeLine(int Division)
	{
		for (int a = 0; a < 5; a++) 
		{
			for (int i = 0; i < Division; i++) {
				MakeRandomSquare (getX(Division) + ((getWidth (Division) * i) * 2), 6+(1.5f*a), Default, Division);

			}
			//Increases division
			Division++;

			//Resets acolor array to -1 and acount to 0
			//--------------------------
			for (int o = 0; o < acolor.Length; o++) {
				acolor [o] = -1;
			}
			acount = 0;
			//--------------------------
		}
	}

	public float getX(int Division)
	{
		switch (Division) 
		{
		case 2:
			return -1.46f;
			break;
		case 3:
			return -1.94f;
			break;
		case 4:
			return -2.2f;
			break;
		case 5:
			return -2.36f;
			break;
		case 6:
			return -2.44f;
			break;
		}
		return 0;
	}

	public float getWidth(int Division)
	{
		switch (Division) 
		{
		case 2:
			return 1.471654f;
			break;
		case 3:
			return 0.9700123f;
			break;
		case 4:
			return 0.7333211f;
			break;
		case 5:
			return 0.5885219f;
			break;
		case 6:
			return 0.4886053f;
			break;
		}
		return 0;
	}

	public void MakeRandomSquare(float xPos, float yPos, Sprite[] def, int division)
	{

		int arrayIndex = Random.Range (0, def.Length);

		//Avoids same color in one line
		//--------------------------
		for (int p = 0; p < acolor.Length; p++) {
			if (acolor [p].Equals (arrayIndex)) {
				p = -1;
				arrayIndex = Random.Range (0, def.Length);
			}
		}
		acolor[acount]=arrayIndex;
		acount++;
		//--------------------------

		Sprite squareSprite = def [arrayIndex];
		string color = getName (arrayIndex);

		GameObject newSquare = Instantiate (getPrefab (division));
		newSquare.name = color;
		newSquare.transform.position = new Vector3 (xPos, yPos, 0);
		newSquare.GetComponent<Square> ().Color = color;
		newSquare.GetComponent<SpriteRenderer> ().sprite = squareSprite;

		//GameObject.FindWithTag ("Player").GetComponent<SpriteRenderer> ().sprite = squareSprite;
	}

	public GameObject getPrefab(int division)
	{
		switch (division) 
		{
		case 2:
			return prefab_2;
			break;
		case 3:
			return prefab_3;
			break;
		case 4:
			return prefab_4;
			break;
		case 5:
			return prefab_5;
			break;
		case 6:
			return prefab_6;
			break;
		}
		return prefab_2;
	}

	public string getName(int ind)
	{
		switch (ind) 
		{
		case 0:
			return "GREEN";
			break;
		case 1:
			return "BLUE";
			break;
		case 2:
			return "RED";
			break;
		case 3:
			return "ORANGE";
			break;
		case 4:
			return "PINK";
			break;
		case 5:
			return "PURPLE";
			break;
		case 6:
			return "YELLOW";
			break;
		case 7:
			return "GRAY";
			break;
		case 8:
			return "BROWN";
			break;
		case 9:
			return "LILA";
			break;
		case 10:
			return "AQUA";
			break;
		case 11:
			return "WINE";
			break;
		}
		return "RIP IN PIECES";
	}
}
