﻿using UnityEngine;
using System.Collections;

public class ShowGameOver : MonoBehaviour {

	static ShowPanels showPanels;	
	static StartOptions startScript;

	public static bool show = false;
	public static int count = 0;

	void Awake()
	{
		showPanels = GetComponent<ShowPanels> ();
		startScript = GetComponent<StartOptions> ();

	}

	public static void showGameOver (int score)
	{
		Time.timeScale = 0;
		showPanels.GameOver (score);
	}

	public static void hideGameOver ()
	{
		showPanels.HideGameOver ();
	}
}
