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
	public bool DefaultActive;

	//GalaxyTheme
	public Sprite[] Galaxy;
	public Sprite[] GalaxyBall;
	public Material[] GalaxyBackground;
	public bool GalaxyActive;

	public void setGalaxyTheme()
	{
		menuBackground.GetComponent<MeshRenderer> ().materials = GalaxyBackground;
	}

	public void setDefaultTheme()
	{
		
	}
}
