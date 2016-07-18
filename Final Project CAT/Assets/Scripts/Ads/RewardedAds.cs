using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class RewardedAds : MonoBehaviour
{
	public void ShowRewardedAd()
	{
		if (Advertisement.IsReady("rewardedVideoZone"))
		{
			var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show("rewardedVideoZone", options);
		}
	}

	private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log ("Happy 20 coins!");
			SaveLoad.SaveCoins (SaveLoad.GetCoins()+20);
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
