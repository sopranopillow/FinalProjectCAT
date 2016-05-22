using UnityEngine;
using System.Collections;

public class ShowGameOver : MonoBehaviour {

	private ShowPanels showPanels;	
	private StartOptions startScript;

	public static bool show = false;

	void Awake()
	{
		showPanels = GetComponent<ShowPanels> ();
		startScript = GetComponent<StartOptions> ();

	}

	void Update()
	{
		if (show == true)
		{
			showGameOver ();
		}
			
	}

	public void showGameOver ()
	{
		Time.timeScale = 0;
		showPanels.ShowGameOver ();
	}
}
