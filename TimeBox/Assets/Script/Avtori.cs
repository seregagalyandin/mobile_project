using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Avtori : MonoBehaviour {

	public int _Start;
	public Text _TextAvtors;
	public float speed;
	public float TimeRead;
	private float tim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(_Start == 1)
		{
			if(_TextAvtors.rectTransform.anchoredPosition.y > 194)
				_TextAvtors.rectTransform.anchoredPosition = new Vector2(0, _TextAvtors.rectTransform.anchoredPosition.y - speed * Time.deltaTime);
			else
			_Start = 2;
		}
		if(_Start == 2)
		{
			tim += Time.deltaTime;
			if(tim > TimeRead)
			{
				_Start = 0;
				tim = 0;
			}
		}
		if(_Start == 0)
		{
			if(_TextAvtors.rectTransform.anchoredPosition.y < 300)
				_TextAvtors.rectTransform.anchoredPosition = new Vector2(0, _TextAvtors.rectTransform.anchoredPosition.y + speed * Time.deltaTime);
		}
	}

	public void SchowAvtors () {
		_Start = 1;
		tim = 0;
	}
}
