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

	public void setGalaxyTheme()
	{
		SaveLoad.SaveTheme ("Galaxy");
		menuBackground.GetComponent<MeshRenderer> ().materials = GalaxyBackground;
	}

	public void setDefaultTheme()
	{
		SaveLoad.SaveTheme ("Default");
		menuBackground.GetComponent<MeshRenderer> ().materials = DefaultBackground;
	}
}
