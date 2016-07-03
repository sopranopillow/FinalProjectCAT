using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShowPanels : MonoBehaviour {

	public GameObject optionsPanel;							//Store a reference to the Game Object OptionsPanel 
	public GameObject optionsTint;							//Store a reference to the Game Object OptionsTint 
	public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
	public GameObject pausePanel;							//Store a reference to the Game Object PausePanel 
	public GameObject gameOver;							//Store a reference to the Game Object PausePanel 
	public GameObject themeOptions;
	public GameObject ScoreText;
	public GameObject TopScoreText;
	public GameObject CoinsText;
	public GameObject loadingPanel;
	public GameObject background;
	public GameObject balance;
	//Call this function to activate and display the Options panel during the main menu
	public void ShowOptionsPanel()
	{
		optionsPanel.SetActive(true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel()
	{
		optionsPanel.SetActive(false);
		optionsTint.SetActive(false);
	}

	public void ShowThemeOptions()
	{
		menuPanel.SetActive (false);
		themeOptions.SetActive (true);
		optionsTint.SetActive (true);
		balance = GameObject.FindGameObjectWithTag ("ThemeBalance");
		balance.GetComponent<UpdateValue> ().UpdateText (SaveLoad.GetCoins().ToString());
	}

	public void HideThemeOptions()
	{
		themeOptions.SetActive (false);
		optionsTint.SetActive (false);
		menuPanel.SetActive (true);
	}

	//Call this function to activate and display the main menu panel during the main menu
	public void ShowMenu()
	{
		menuPanel.SetActive (true);
		ShowGameOver.hideGameOver ();
		background.GetComponent<ScrollingB> ().speed = 0.3f;
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu()
	{
		menuPanel.SetActive (false);
		optionsTint.SetActive (false);
	}
	
	//Call this function to activate and display the Pause panel during game play
	public void ShowPausePanel()
	{
		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
	}

	public void GameOver(int score, int coins)
	{
		gameOver.SetActive (true);
		optionsTint.SetActive(true);

		ScoreText = GameObject.FindGameObjectWithTag ("ScoreGO");
		TopScoreText = GameObject.FindGameObjectWithTag ("TopScoreGO");
		CoinsText = GameObject.FindGameObjectWithTag ("CoinsGO");

		//checkScore
		//if greater changetopscore

		if (SaveLoad.GetScore() < score)
		{
			SaveLoad.SaveScore (score);
			ScoreText.GetComponent<UpdateValue> ().UpdateText ("            "+score.ToString());
			TopScoreText.GetComponent<UpdateValue> ().UpdateText ("                   "+score.ToString ());
		} else
		{
			ScoreText.GetComponent<UpdateValue> ().UpdateText ("            "+score.ToString());
			TopScoreText.GetComponent<UpdateValue> ().UpdateText ("                  "+SaveLoad.GetScore().ToString());
		}
		SaveLoad.SaveCoins (coins);
		CoinsText.GetComponent<UpdateValue> ().UpdateText ("            " + SaveLoad.GetCoins ().ToString ());
	}

	public void HideGameOver()
	{
		gameOver.SetActive (false);
		optionsTint.SetActive(false);
		Time.timeScale = 1;
		SceneManager.LoadScene (0);
		HideMenu ();
	}

	public void PlayAgain()
	{
		background.GetComponent<ScrollingB> ().speed = 0.3f;
		gameOver.SetActive (false);
		optionsTint.SetActive(false);
		Time.timeScale = 1;
		SceneManager.LoadScene(1);
	}

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel()
	{
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);
	}
}
