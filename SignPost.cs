using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	private int coinCount;
	private string uiTextFormat = "Status...COMPLETE!\n Coins Collected: {0}/25\n [click to restart]";

	void Start()
	{
		coinCount = 0;
	}

	public void ResetScene() 
	{
		// "UdacityVR/Scenes/mkII"
		SceneManager.LoadScene ("mkII");
	}

	public void UpdateCount()
	{
		this.coinCount++;
		Text signText = GetComponent<Text> ();
		signText.text = string.Format (uiTextFormat, this.coinCount);
	}
}