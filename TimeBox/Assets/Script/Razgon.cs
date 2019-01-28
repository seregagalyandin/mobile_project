using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Razgon : MonoBehaviour {
	public float speedIzmen;
	public Text textDate, textDate2, textDate3, TextInform;
	public Mask _mask;
	public Image imageGrad, Obvod, msk, Strelka;
	public int DownUpGradSize, _Start = 0;
	public CameraPosition CP;
	public Canvas _canvas;
	public SpriteRenderer black;
	public float tim;
	public GameObject baggi, particl;
	public AudioSource _AudioSource;
	//public float _pitch;
	public AudioClip clipTime;
	public int stopGo = 0;
	public int pl;
	// Use this for initialization
	void Start () {
		pl = PlayerPrefs.GetInt("numLevel");
		if(pl == 0)
		{
			pl = 1;
		}
		//DateTime dt = DateTime.Now;
			textDate.text = DateTime.Now.ToString("dd.mm.yyyy");
			textDate2.text = "10.26.1985";
			textDate3.text = "12.10.1996";
	}
	
	// Update is called once per frame
	void Update () {
		if(_Start == 1)
		{
			if(stopGo == 0)
			Strelka.transform.rotation =  Quaternion.Euler(0,0, Strelka.transform.eulerAngles.z - _mask.rectTransform.sizeDelta.y/2.15f*Time.deltaTime);
		}

		if(_Start == 2)
		{
			tim += Time.deltaTime;
			if(tim > 0.2f)
			{
				textDate.text = "10.26.1985";
				textDate2.text = DateTime.Now.ToString("dd.mm.yyyy");
				textDate3.text = DateTime.Now.ToString("dd.mm.yyyy");
				//_canvas.enabled = true;
				_mask.enabled = true;
				Obvod.enabled = true;
				textDate.enabled = true;
				imageGrad.enabled = true;
				msk.enabled = true;
				black.enabled = false;
				baggi.GetComponent<Rigidbody2D>().AddForce(baggi.transform.right * 5000);
				_Start = 3;
			}
		}

		if(_Start == 1 && Strelka.transform.eulerAngles.z > 122 && Strelka.transform.eulerAngles.z < 330)
		{
			stopGo = 1;
			//_canvas.enabled = false;
			_mask.enabled = false;
			Obvod.enabled = false;
			textDate.enabled = false;
			imageGrad.enabled = false;
			msk.enabled = false;
			black.enabled = true;
			//_AudioSource.Stop();
			_AudioSource.PlayOneShot(clipTime);
			//_AudioSource.loop = false;
			CP.speedForward = 0;
			particl.SetActive(true);
			_Start = 2;
			//textDate.text = "Дата:\n 10/26/1985";
			Camera.main.GetComponent<UnityStandardAssets.ImageEffects.Grayscale>().enabled = true;
			if(Input.GetMouseButtonUp(0))
			{
				/*//_canvas.enabled = false;
				_mask.enabled = false;
				Obvod.enabled = false;
				textDate.enabled = false;
				imageGrad.enabled = false;
				msk.enabled = false;
				black.enabled = true;
				//_AudioSource.Stop();
				_AudioSource.PlayOneShot(clipTime);
				//_AudioSource.loop = false;
				CP.speedForward = 0;
				particl.SetActive(true);
				_Start = 2;
				//textDate.text = "Дата:\n 10/26/1985";
				Camera.main.GetComponent<UnityStandardAssets.ImageEffects.Grayscale>().enabled = true;*/
			}
		}

		if(_Start == 0)
		{
			if(Input.GetMouseButtonUp(0))
			{
				TextInform.enabled = false;
				CP.speedForward = _mask.rectTransform.sizeDelta.y*2;
				_Start = 1;
			}
			if(DownUpGradSize == 0)
			{
				if(_mask.rectTransform.sizeDelta.y > 1)
				{
					_mask.rectTransform.sizeDelta = new Vector2(11.7f, _mask.rectTransform.sizeDelta.y - speedIzmen*pl * Time.deltaTime);
					_AudioSource.pitch -= Time.deltaTime * 0.77f;
				}
				else
				{
					DownUpGradSize = 1;
				}
			}
			if(DownUpGradSize == 1)
			{
				if(_mask.rectTransform.sizeDelta.y < 65)
				{
					_mask.rectTransform.sizeDelta = new Vector2(11.7f, _mask.rectTransform.sizeDelta.y + speedIzmen*pl * Time.deltaTime);
					_AudioSource.pitch += Time.deltaTime * 0.77f;

				}
				else
				{
					DownUpGradSize = 0;
				}
			}
		}
	}
	public void OnMenu() {
		Application.LoadLevel(1);
	}
	public void OnUpdateLevel() {
		PlayerPrefs.SetInt ("StopOneRaz" + pl.ToString (), 1);
		Application.LoadLevel(2);
	}
}
