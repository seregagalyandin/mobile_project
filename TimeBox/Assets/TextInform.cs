using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextInform : MonoBehaviour {

	public Text _textInform;
	public float tim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (_textInform.enabled == true) {
			tim += Time.deltaTime;
			if(tim > 3)
			{
				_textInform.enabled = false;
				tim = 0;
			}
		}
	}

	public void OnSchowInform (string _text)
	{
		_textInform.text = _text;
		_textInform.enabled = true;
		tim = 0;
	}
}
