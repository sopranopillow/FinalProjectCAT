using UnityEngine;
using System.Collections;

public class GlobalProperties : MonoBehaviour {
	public int currentGroup;
	public GameObject currentSquare;
	public GameObject ball;
	public GameObject background;
	public Camera cam;
	public GameObject themeOptions;

	public void setThemes()
	{
		//themeOptions = GameObject.FindGameObjectWithTag ("ThemeOptions");

		//Setup theme
		if (SaveLoad.getTheme () == "Default")
		{
			background.GetComponent<MeshRenderer> ().materials = themeOptions.GetComponent<ThemeScript> ().DefaultBackground;
			background.GetComponent<ScrollingB> ().speed = 0.3f;
			cam.GetComponent<BoxCreation> ().Default = themeOptions.GetComponent<ThemeScript> ().Default;
			ball.GetComponent<BallTeleportSimple> ().PTextures = themeOptions.GetComponent<ThemeScript> ().DefaultBall;
			ball.GetComponent<ColorChangePlayer> ().PTextures = themeOptions.GetComponent<ThemeScript> ().DefaultBall;
		} else if (SaveLoad.getTheme () == "Galaxy")
		{
			background.GetComponent<MeshRenderer> ().materials = themeOptions.GetComponent<ThemeScript> ().GalaxyBackground;
			background.GetComponent<ScrollingB> ().speed = 0.3f;
			cam.GetComponent<BoxCreation> ().Default = themeOptions.GetComponent<ThemeScript> ().Galaxy;
			ball.GetComponent<BallTeleportSimple> ().PTextures = themeOptions.GetComponent<ThemeScript> ().GalaxyBall;
			ball.GetComponent<ColorChangePlayer> ().PTextures = themeOptions.GetComponent<ThemeScript> ().GalaxyBall;
		} else if (SaveLoad.getTheme () == "Stripes")
		{
			background.GetComponent<MeshRenderer> ().materials = themeOptions.GetComponent<ThemeScript> ().StripesBackground;
			background.GetComponent<ScrollingB> ().speed = 0.3f;
			cam.GetComponent<BoxCreation> ().Default = themeOptions.GetComponent<ThemeScript> ().Stripes;
			ball.GetComponent<BallTeleportSimple> ().PTextures = themeOptions.GetComponent<ThemeScript> ().StripesBall;
			ball.GetComponent<ColorChangePlayer> ().PTextures = themeOptions.GetComponent<ThemeScript> ().StripesBall;
		}
	}

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
