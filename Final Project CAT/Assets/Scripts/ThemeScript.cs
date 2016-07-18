using UnityEngine;
using System.Collections;

public class ThemeScript : MonoBehaviour
{
	//Changes
	public GameObject menuBackground;

	//Default Theme
	public Sprite[] Default;
	public Sprite[] DefaultBall;
	public Material[] DefaultBackground;

	//GalaxyTheme
	public Sprite[] Galaxy;
	public Sprite[] GalaxyBall;
	public Material[] GalaxyBackground;

	//StripesTheme
	public Sprite[] Stripes;
	public Sprite[] StripesBall;
	public Material[] StripesBackground;

	public void setGalaxyTheme()
	{
		if(SaveLoad.getPaidThemes ("Galaxy") == "Paid")
		{
			SaveLoad.SaveTheme ("Galaxy");
			menuBackground.GetComponent<MeshRenderer> ().materials = GalaxyBackground;
		} else if (SaveLoad.GetCoins () > 200)
		{
			SaveLoad.SaveCoins (SaveLoad.GetCoins () - 200);
			SaveLoad.setPaidThemes ("Galaxy", "Paid");
		}
	}

	public void setStripesTheme()
	{
		if (SaveLoad.getPaidThemes ("Stripes") == "Paid")
		{
			SaveLoad.SaveTheme ("Stripes");
			menuBackground.GetComponent<MeshRenderer> ().materials = StripesBackground;
		} else if (SaveLoad.GetCoins () > 200)
		{
			SaveLoad.SaveCoins (SaveLoad.GetCoins () - 200);
			SaveLoad.setPaidThemes ("Stripes", "Paid");
		}
	}

	public void setDefaultTheme()
	{
		SaveLoad.SaveTheme ("Default");
		menuBackground.GetComponent<MeshRenderer> ().materials = DefaultBackground;
	}
}
