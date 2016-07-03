using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour
{
	public static void SaveScore(int score)
	{
		PlayerPrefs.SetInt ("TopScore", score);
	}

	public static void SaveCoins(int coins)
	{
		PlayerPrefs.SetInt ("Coins", GetCoins()+coins);
	}

	public static void SaveTheme(string theme)
	{
		PlayerPrefs.SetString ("Theme", theme);
	}

	public static int GetScore()
	{
		return PlayerPrefs.GetInt ("TopScore");
	}

	public static int GetCoins()
	{
		return PlayerPrefs.GetInt ("Coins");
	}

	public static string getTheme()
	{
		return PlayerPrefs.GetString ("Theme");
	}
}
