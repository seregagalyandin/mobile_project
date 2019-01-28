using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().clip = clip;
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
