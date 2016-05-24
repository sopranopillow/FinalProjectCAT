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
		PlayerPrefs.SetInt ("Coins", coins);
	}

	public static int GetScore()
	{
		return PlayerPrefs.GetInt ("TopScore");
	}

	public static int GetCoins()
	{
		return PlayerPrefs.GetInt ("Coins");
	}
}
