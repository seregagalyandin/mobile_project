using UnityEngine;
using System.Collections;

public class EnableSled : MonoBehaviour {

	public GameObject partilc;
	public float tim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.activeSelf == true)
		{
			tim += Time.deltaTime;
			if(tim > 1)
			{
				partilc.transform.parent = null;
			}
		}
	}
}
