using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateValue : MonoBehaviour 
{
	public Text text;

	public void UpdateText(string text)
	{
		this.text.text = text;
	}
}
