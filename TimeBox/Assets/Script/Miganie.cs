using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Miganie : MonoBehaviour {

	public Text Text1, Text2;
	public Image obvod;
	public float tim;
	public int go;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(go == 0)
		{
			tim += Time.deltaTime;
			if(tim > 0.5f)
			{
				Text1.enabled = false;
				Text2.enabled = false;
				obvod.enabled = false;
				go = 1;
				tim = 0;
			}
		}
		if(go == 1)
		{
			tim += Time.deltaTime;
			if(tim > 0.1f)
			{
				Text1.enabled = true;
				Text2.enabled = true;
				obvod.enabled = true;
				go = 0;
				tim = 0;
			}
		}
	}
}
