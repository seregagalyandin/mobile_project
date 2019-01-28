using UnityEngine;
using System.Collections;

public class ButLevel2 : MonoBehaviour {


	// Use this for initialization 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick (int lvl) {
		PlayerPrefs.SetInt("numLevel", lvl);
		Application.LoadLevel(2);
	}
	public void OnMenu () {
		//Application.LoadLevel(1);
	}
}
