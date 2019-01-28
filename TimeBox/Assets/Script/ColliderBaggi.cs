using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderBaggi : MonoBehaviour {

	public Text over;
	public int numLevel;
	public int Score;
	public int TimeStart;
	public float tim;
	public Razgon _Razgon;
	public AudioSource _AudioSource, _AudioSource2;
	public AudioClip lomClip, BritchClip;
	public int col = 0;
	public int sc = 0;
	// Use this for initialization
	void Start () {
		Score = 0;
		numLevel = PlayerPrefs.GetInt("numLevel");
	}
	
	// Update is called once per frame
	void Update () {
		if(TimeStart == 1)
		{
			tim += Time.deltaTime;
			if(tim > 5)
			{
				int vr = PlayerPrefs.GetInt("ScoreAll");
				int vr2 = sc + vr;
				PlayerPrefs.SetInt("ScoreAll", vr2);

				if(col >= PlayerPrefs.GetInt ("CountSL" + numLevel.ToString ()))
				{
					PlayerPrefs.SetInt ("ColSlom" + numLevel.ToString (), 1);
				}
				if(PlayerPrefs.GetInt(numLevel.ToString()) < PlayerPrefs.GetInt("Ms" + numLevel.ToString()))
					PlayerPrefs.SetInt ("StopOneRaz" + numLevel.ToString (), 1);
				if(PlayerPrefs.GetInt(numLevel.ToString()) >= PlayerPrefs.GetInt("Ms" + numLevel.ToString()))
				{
					if(PlayerPrefs.GetInt ("StopOneRaz") == 0)
					{
						PlayerPrefs.SetInt("BFG3000", 1);
					}
					PlayerPrefs.SetInt ("StopOneRaz" + numLevel.ToString (), 2);
				}
				Application.LoadLevel(1);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collis2D) {

			if(collis2D.gameObject.tag == "Britch")
			{
				if(_Razgon._Start == 1)
				{
					_Razgon._Start = 4;
				}
				_AudioSource.pitch = 1;
				_AudioSource.volume = 0.2f;
				if(collis2D.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 2)
				{
				col ++;
				if(!_AudioSource2.isPlaying)
				{
					_AudioSource2.clip = BritchClip;
					_AudioSource2.Play();
				}
					if(TimeStart == 0)
						TimeStart = 1;
					tim = 0;
					collis2D.gameObject.GetComponent<Collider2D>().enabled = false;
					collis2D.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
					collis2D.gameObject.GetComponent<SpriteRenderer>().enabled = false;
					collis2D.gameObject.GetComponent<CreateBRTtoDesrt>().DSTR();
					Score += 100;
					
					if(_Razgon._Start == 3)
				{
					sc += 100;

					if(Score > PlayerPrefs.GetInt(numLevel.ToString()))
						PlayerPrefs.SetInt(numLevel.ToString(), Score);
				}
				else
				{
					over.enabled = true;
				}
				}
			}
			if(collis2D.gameObject.tag == "Derevo")
			{
				if(_Razgon._Start == 1)
				{
					_Razgon._Start = 4;
				}
				_AudioSource.pitch = 1;
				_AudioSource.volume = 0.2f;
				if(collis2D.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 1f)
				{
					col ++;
					if(!_AudioSource2.isPlaying)
					{
						_AudioSource2.clip = lomClip;
						_AudioSource2.Play();
					}
					if(TimeStart == 0)
						TimeStart = 1;
					tim = 0;
					collis2D.gameObject.GetComponent<Collider2D>().enabled = false;
					collis2D.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
					collis2D.gameObject.GetComponent<SpriteRenderer>().enabled = false;
					collis2D.gameObject.GetComponent<CreateBRTtoDesrt>().DSTR();
					Score += 70;
					if(_Razgon._Start == 3)
				{
					sc += 70;

					if(Score > PlayerPrefs.GetInt(numLevel.ToString()))
						PlayerPrefs.SetInt(numLevel.ToString(), Score);
				}
				else
				{
					over.enabled = true;
				}
				}
			}
			if(collis2D.gameObject.tag == "window")
			{
				if(_Razgon._Start == 1)
				{
					_Razgon._Start = 4;
				}
				_AudioSource.pitch = 1;
				_AudioSource.volume = 0.2f;
				if(collis2D.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 0.6f)
				{
				col ++;
				if(!_AudioSource2.isPlaying)
				{
					_AudioSource2.clip = BritchClip;
					_AudioSource2.Play();
				}
					if(TimeStart == 0)
						TimeStart = 1;
					tim = 0;
					collis2D.gameObject.GetComponent<Collider2D>().enabled = false;
					collis2D.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
					collis2D.gameObject.GetComponent<SpriteRenderer>().enabled = false;
					collis2D.gameObject.GetComponent<CreateBRTtoDesrt>().DSTR();
					Score += 40;
					if(_Razgon._Start == 3)
				{
					sc += 40;
				
					if(Score > PlayerPrefs.GetInt(numLevel.ToString()))
						PlayerPrefs.SetInt(numLevel.ToString(), Score);
				}
				}
			}
			if(collis2D.gameObject.tag == "Zhelezo")
			{
			if(_Razgon._Start == 1)
			{
				_Razgon._Start = 4;
			}
				_AudioSource.pitch = 1;
				_AudioSource.volume = 0.2f;
				if(collis2D.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 2.8f)
				{
				col ++;
				if(!_AudioSource2.isPlaying)
				{
					_AudioSource2.clip = BritchClip;
					_AudioSource2.Play();
				}
					if(TimeStart == 0)
						TimeStart = 1;
					tim = 0;
					collis2D.gameObject.GetComponent<Collider2D>().enabled = false;
					collis2D.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
					collis2D.gameObject.GetComponent<SpriteRenderer>().enabled = false;
					collis2D.gameObject.GetComponent<CreateBRTtoDesrt>().DSTR();
					Score += 150;
				if(_Razgon._Start == 3)
				{
					sc += 150;

					if(Score > PlayerPrefs.GetInt(numLevel.ToString()))
						PlayerPrefs.SetInt(numLevel.ToString(), Score);
				}
				}
			}
		}
}

