using UnityEngine;
using System.Collections;

public class setupUIMenu : MonoBehaviour 
{
	public GameObject themeOptions;

	public void Start()
	{
		if (SaveLoad.getTheme () == null)
		{
			SaveLoad.SaveTheme ("Default");
		} else if (SaveLoad.getTheme () == "Default")
		{
			themeOptions.GetComponent<ThemeScript> ().setDefaultTheme ();
		} else if (SaveLoad.getTheme () == "Galaxy")
		{
			themeOptions.GetComponent<ThemeScript> ().setGalaxyTheme ();
		}
	}
}
