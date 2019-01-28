using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public int cont;
	public GameObject _text;
	public Image Otchivka1, Otchivka2, Otchivka3, Otchivka4, Otchivka5, Otchivka6;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("ScoreAll", 0);
		//PlayerPrefs.SetInt ("BFG3000", 0);
		if (PlayerPrefs.GetInt ("ScoreAll") > 3000) 
		{
			Otchivka4.enabled = true;
			_text.SetActive(false);
		}
		if (PlayerPrefs.GetInt ("ScoreAll") > 9000) 
		{
			Otchivka5.enabled = true;
			_text.SetActive(false);
		}
		if (PlayerPrefs.GetInt ("ScoreAll") > 20000) 
		{
			Otchivka6.enabled = true;
			_text.SetActive(false);
		}
		PlayerPrefs.SetInt ("CountSL0", 45);
		PlayerPrefs.SetInt ("CountSL1", 45);
		PlayerPrefs.SetInt ("CountSL2", 45);
		PlayerPrefs.SetInt ("CountSL3", 48);
		PlayerPrefs.SetInt ("CountSL4", 74);
		PlayerPrefs.SetInt ("CountSL5", 39);
		PlayerPrefs.SetInt ("CountSL6", 66);
		PlayerPrefs.SetInt ("CountSL7", 44);
		for (int i = 0; i < 7; i++) {
			if(PlayerPrefs.GetInt ("ColSlom" + i.ToString ()) == 1)
			{
				cont ++;
			}
		}
		if (cont == 7) {
			Otchivka3.enabled = true;
			_text.SetActive(false);
		}
		cont = 0;

		if (PlayerPrefs.GetInt ("BFG3000") == 1) {
			Otchivka2.enabled = true;
			_text.SetActive(false);
		}
		for (int i = 0; i < 7; i++) {
			if(PlayerPrefs.GetInt ("StopOneRaz" + i.ToString ()) == 2)
			{
				cont ++;
			}
		}
		if (cont == 7) {
			Otchivka1.enabled = true;
			_text.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnStart()
	{
		Application.LoadLevel(1);
	}
	/*public void OnCreators()
	{
	}*/
	public void OnQuit()
	{
		Application.Quit();
	}
}
