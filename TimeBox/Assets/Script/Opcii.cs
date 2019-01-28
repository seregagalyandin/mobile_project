using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Opcii : MonoBehaviour {

	public int SGnum = 0, PokazOP = 0;
	public GameObject Buttons;
	public Image Ukaz, Ukaz2;
	public float speed;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt("SD", 0);
		if(PlayerPrefs.GetInt("SD") == 1)
		{
			AudioListener.volume = 1;
			Ukaz2.rectTransform.anchoredPosition = new Vector2(38, Ukaz2.rectTransform.anchoredPosition.y);
		}
		if(PlayerPrefs.GetInt("SD") == 0)
		{
			AudioListener.volume = 0;
			Ukaz2.rectTransform.anchoredPosition = new Vector2(-40, Ukaz2.rectTransform.anchoredPosition.y);
		}

		SGnum = PlayerPrefs.GetInt("SGnum");
		if(SGnum == 0)
		{
			QualitySettings.antiAliasing = 0;
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, 86);
		}
		if(SGnum == 2)
		{
			QualitySettings.antiAliasing = 2;
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, 39);
		}
		if(SGnum == 4)
		{
			QualitySettings.antiAliasing = 4;
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, -6);
		}
		if(SGnum == 8)
		{
			QualitySettings.antiAliasing = 8;
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, -51);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//print(Buttons.transform.position.x);
		if(PokazOP == 1)
		{
			if(Buttons.transform.position.x < 110)
			{
				Buttons.transform.position = new Vector2(Buttons.transform.position.x + speed * Time.deltaTime, Buttons.transform.position.y);
			}
		
		}
		if(PokazOP == 0)
		{
			if(Buttons.transform.position.x > -110)
			{
				Buttons.transform.position = new Vector2(Buttons.transform.position.x - speed * Time.deltaTime, Buttons.transform.position.y);
			}
		
		}
	}

	public void OnQuality (int numL) {
		PlayerPrefs.SetInt("SGnum", numL);
		if(numL == 0)
		{
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, 86);
		}
		if(numL == 2)
		{
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, 39);
		}
		if(numL == 4)
		{
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, -6);
		}
		if(numL == 8)
		{
			Ukaz.rectTransform.anchoredPosition = new Vector2(87, -51);
		}
		QualitySettings.antiAliasing = numL;
		PokazOP = 0;
	}

	public void OnPokaz () {
		PokazOP = 1;
	}
	public void OnSound (int n) {
		if(n == 1)
		{
			AudioListener.volume = 1;
			Ukaz2.rectTransform.anchoredPosition = new Vector2(38, Ukaz2.rectTransform.anchoredPosition.y);
		}
		if(n == 0)
		{
			AudioListener.volume = 0;
			Ukaz2.rectTransform.anchoredPosition = new Vector2(-40, Ukaz2.rectTransform.anchoredPosition.y);
		}
		PlayerPrefs.SetInt("SD", n);
		PokazOP = 0;
	}

	public void OnObnull () {
		PlayerPrefs.SetInt("0", 0);
		PlayerPrefs.SetInt("1", 0);
		PlayerPrefs.SetInt("2", 0);
		PlayerPrefs.SetInt("3", 0);
		PlayerPrefs.SetInt("4", 0);
		PlayerPrefs.SetInt("5", 0);
		PlayerPrefs.SetInt("6", 0);
		PlayerPrefs.SetInt("7", 0);
	}
}
