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
		} else if (SaveLoad.getTheme () == "Galaxy" && SaveLoad.getPaidThemes ("Galaxy") == "Paid")
		{
			themeOptions.GetComponent<ThemeScript> ().setGalaxyTheme ();
		} else if (SaveLoad.getTheme () == "Stripes" && SaveLoad.getPaidThemes ("Stripes") == "Paid")
		{
			themeOptions.GetComponent<ThemeScript> ().setStripesTheme ();
		} else
		{
			themeOptions.GetComponent<ThemeScript> ().setDefaultTheme ();
		}


		if (SaveLoad.getPaidThemes ("Galaxy") == null)
		{
			SaveLoad.setPaidThemes ("Stripes", "NotPaid");
			SaveLoad.setPaidThemes ("Galaxy", "NotPaid");
		} 
	}
}
