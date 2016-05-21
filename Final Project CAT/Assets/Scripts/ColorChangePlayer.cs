using UnityEngine;
using System.Collections;

public class ColorChangePlayer : MonoBehaviour {

	public Sprite[] PTextures;

	public void changecolors(Sprite[] def, string name)
	{
		gameObject.name = name;
		gameObject.GetComponent<BallName> ().ColorP = name;
		gameObject.GetComponent<SpriteRenderer> ().sprite = getSprite(name);
	}

	public Sprite getSprite(string name)
	{
		switch (name) {
		case "GREEN":
			return PTextures [0];
			break;
		case "BLUE":
			return PTextures [1];
			break;
		case "RED":
			return PTextures [2];
			break;
		case "ORANGE":
			return PTextures [3];
			break;
		case "PINK":
			return PTextures [4];
			break;
		case "PURPLE":
			return PTextures [5];
			break;
		case "YELLOW":
			return PTextures [6];
			break;
		case "GRAY":
			return PTextures [7];
			break;
		case "BROWN":
			return PTextures [8];
			break;
		case "LILA":
			return PTextures [9];
			break;
		case "AQUA":
			return PTextures [10];
			break;
		case "WINE":
			return PTextures [11];
			break;
		}
		return PTextures[0];
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