using UnityEngine;
using System.Collections;

public class LoadLevelandReolad : MonoBehaviour {
	public int numLevel = 0;
	public GameObject[] HouseNum;
	// Use this for initialization
	void Start () {
		numLevel = PlayerPrefs.GetInt("numLevel");
		Instantiate(HouseNum[numLevel], HouseNum[numLevel].transform.position, Quaternion.identity); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
