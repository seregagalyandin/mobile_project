using UnityEngine;
using System.Collections;

public class TimeDestroybrt : MonoBehaviour {

	public float timeDestroy;
	private float tim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tim += Time.deltaTime;
		if(tim > timeDestroy)
		{
			Destroy(gameObject);
		}
	}
}
