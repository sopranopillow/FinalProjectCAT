using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class RewardedAds : MonoBehaviour
{
	private bool give = false;

	void Awake()
	{
		Advertisement.Initialize("1096474", false);
	}

	public void ShowRewardedAd()
	{
		if (Advertisement.IsReady("rewardedVideo"))
		{
			var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show("rewardedVideo", options);
		}
	}

	private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log ("Happy 20 coins!");
			SaveLoad.SaveCoinsNoAdd (SaveLoad.GetCoins () + 20);
			break;
		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
			break;
		}
	}
}
