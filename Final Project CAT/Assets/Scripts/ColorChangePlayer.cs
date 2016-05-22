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
}