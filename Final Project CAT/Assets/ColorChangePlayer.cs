using UnityEngine;
using System.Collections;

public class ColorChangePlayer : MonoBehaviour {

	public Sprite[] PTextures;



	void Start ()
	{
		changecolor(PTextures);
	}
		

	public void changecolor(Sprite[] def)
	{
		int arrayIndex = Random.Range (0, def.Length);


		Sprite playerSprite = def [arrayIndex];
		string colorptex = getName (arrayIndex);

		gameObject.name = colorptex;
		gameObject.GetComponent<BallName> ().ColorP = colorptex;
		gameObject.GetComponent<SpriteRenderer> ().sprite = playerSprite;
	}


	public string getName(int ind)
	{
		switch (ind) {
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