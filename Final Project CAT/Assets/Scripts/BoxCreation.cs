using UnityEngine;
using System.Collections;

public class BoxCreation : MonoBehaviour {

	public Sprite[] Default;

	public GameObject prefab_2;
	public GameObject prefab_3;
	public GameObject prefab_4;
	public GameObject prefab_5;
	public GameObject prefab_6;

	public float Duration;
	public float limitDuration;
	public float Speed;

	public float wait;

	//Cuantas lineas por cada division
	public int[] amount  = new int[4];

	//Contador de cada grupo de lineas
	public int[] timesToCreate  = new int[4];

	//Tiempo de espera entre lineas
	public float waitTime =1f;

	public float x;
	public float y;

	int[] acolor = new int [6];

	int acount=0;

	void Start ()
	{
		timesToCreate [0] = amount [0];
		timesToCreate [1] = amount [1];
		timesToCreate [2] = amount [2];
		timesToCreate [3] = amount [3];
		InvokeRepeating ("MakeLine", waitTime, waitTime);
	}

	void Update()
	{
	}

	public int getDiv()
	{
		if (timesToCreate [0] == 0) {
			if (timesToCreate [1] == 0) {
				if (timesToCreate [2] == 0) {
					if (timesToCreate [3] == 0) {
						return 6;
						Debug.Log("Flag 4");
					}else {
						timesToCreate [3] = timesToCreate [3]-1;
						return 5;
						Debug.Log("Flag 3");
					}
				}else {
					timesToCreate [2] = timesToCreate [2]-1;
					return 4;
					Debug.Log("Flag 2");
				}
			} else {
				timesToCreate [1] = timesToCreate [1]-1;
				return 3;
				Debug.Log("Flag 1");
			}
		} else {
			timesToCreate [0] = timesToCreate [0]-1;
			return 2;
			Debug.Log("Flag 0");
		}
	}

	public void MakeLine()
	{
		int Division = getDiv();

		for (int i = 0; i < Division; i++) 
		{
			MakeRandomSquare (getX(Division) + ((getWidth (Division) * i) * 2), Default, Division);
		}

		//Resets acolor array to -1 and acount to 0
		for (int o = 0; o < acolor.Length; o++) {
			acolor [o] = -1;
		}
		acount = 0; 
		if (Duration > limitDuration)
		{
			Duration -= Speed;
			if (waitTime > 0.5f) {
				if (waitTime > 0.8f)
					waitTime -= wait / 3;
				else if (waitTime > 0.3f)
					waitTime -= wait / 2;
				else
					waitTime -= wait;
			}
		}
		CancelInvoke ("MakeLine");
		InvokeRepeating ("MakeLine", waitTime, waitTime);
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

	public void MakeRandomSquare(float xPos, Sprite[] def, int division)
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
		newSquare.transform.position = new Vector3 (xPos, y, 0.2f);
		newSquare.GetComponent<Square> ().Color = color;
		newSquare.GetComponent<Square> ().Speed = Speed;
		newSquare.GetComponent<Square> ().Duration = Duration;
		newSquare.GetComponent<Square> ().limitDuration = limitDuration;
		newSquare.GetComponent<SpriteRenderer> ().sprite = squareSprite;

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
