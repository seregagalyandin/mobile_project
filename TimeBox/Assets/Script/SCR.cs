using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SCR : MonoBehaviour {
	public Text[] _scoreText;
	public Text[] _DostizhProcent;
	public GameObject[] _ButtonLevel;
	public int[] Score;
	public float[] maxScore;
	public float d2 = 12;
	public int d1;

	// Use this for initialization
	void Start () {
	
		Score[0] = PlayerPrefs.GetInt("0");
		Score[1] = PlayerPrefs.GetInt("1");
		Score[2] = PlayerPrefs.GetInt("2");
		Score[3] = PlayerPrefs.GetInt("3");
		Score[4] = PlayerPrefs.GetInt("4");
		Score[5] = PlayerPrefs.GetInt("5");
		Score[6] = PlayerPrefs.GetInt("6");
		Score[7] = PlayerPrefs.GetInt("7");
		_scoreText[0].text = Score[0] + "/" + maxScore[0];
		PlayerPrefs.SetInt ("Ms0", System.Convert.ToInt32(maxScore[0]));
		_scoreText[1].text = Score[1] + "/" + maxScore[1];
		PlayerPrefs.SetInt ("Ms1", System.Convert.ToInt32(maxScore [1]));
		_scoreText[2].text = Score[2] + "/" + maxScore[2];
        PlayerPrefs.SetInt ("Ms2", System.Convert.ToInt32(maxScore [2]));
		_scoreText[3].text = Score[3] + "/" + maxScore[3];
	    PlayerPrefs.SetInt ("Ms3", System.Convert.ToInt32(maxScore [3]));
		_scoreText[4].text = Score[4] + "/" + maxScore[4];
		PlayerPrefs.SetInt ("Ms4", System.Convert.ToInt32(maxScore [4]));
		_scoreText[5].text = Score[5] + "/" + maxScore[5];
	    PlayerPrefs.SetInt ("Ms5", System.Convert.ToInt32(maxScore [5]));
		_scoreText[6].text = Score[6] + "/" + maxScore[6];
		PlayerPrefs.SetInt ("Ms6", System.Convert.ToInt32(maxScore [6]));
		_scoreText[7].text = Score[7] + "/" + maxScore[7];
		PlayerPrefs.SetInt ("Ms7", System.Convert.ToInt32(maxScore [7]));
		for (int i = 0; i < _DostizhProcent.Length; i++) {
			d2 = Score [i];
			d1 = System.Convert.ToInt32 ((d2 / maxScore[i]) * 100);
			if (d1 > 100)
				d1 = 100;
			_DostizhProcent [i].text = "Дом уничтожен на " + d1 + "%";
			//-------------------------------------------------------
		}

		if(Score[0] >= maxScore[0])
			_ButtonLevel[1].SetActive(true);
		if (Score [0] - maxScore[0] >= 200) {
			_scoreText[0].color = new Color(1, 1, 0, 1);
		}
		if(Score[1] >= maxScore[1])
			_ButtonLevel[2].SetActive(true);
		if (Score [1] - maxScore[1] >= 200) {
			_scoreText[1].color = new Color(1, 1, 0, 1);
		}
		if(Score[2] >= maxScore[2])
			_ButtonLevel[3].SetActive(true);
		if (Score [2] - maxScore[2] >= 200) {
			_scoreText[2].color = new Color(1, 1, 0, 1);
		}
		if(Score[3] >= maxScore[3])
			_ButtonLevel[4].SetActive(true);
		if (Score [3] - maxScore[3] >= 200) {
			_scoreText[3].color = new Color(1, 1, 0, 1);
		}
		if(Score[4] >= maxScore[4])
			_ButtonLevel[5].SetActive(true);
		if (Score [4] - maxScore[4] >= 200) {
			_scoreText[4].color = new Color(1, 1, 0, 1);
		}
		if(Score[5] >= maxScore[5])
			_ButtonLevel[6].SetActive(true);
		if (Score [5] - maxScore[5] >= 200) {
			_scoreText[5].color = new Color(1, 1, 0, 1);
		}
		if(Score[6] >= maxScore[6])
			_ButtonLevel[7].SetActive(true);
		if (Score [6] - maxScore[6] >= 200) {
			_scoreText[6].color = new Color(1, 1, 0, 1);
		}
		if (Score [7] - maxScore[7] >= 200) {
			_scoreText[7].color = new Color(1, 1, 0, 1);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMenu() {
		Application.LoadLevel(0);
	}
}
