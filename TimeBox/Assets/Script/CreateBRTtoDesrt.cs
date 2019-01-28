using UnityEngine;
using System.Collections;

public class CreateBRTtoDesrt : MonoBehaviour {

	public GameObject PrefabBrt, OchkiPrefab;
	public float Force = 50;
	public float tim;
	public int goTim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(goTim == 1)
		{
			tim += Time.deltaTime;
			if(tim > 1f)
			{
				Destroy(gameObject);
			}
		}
	}

	public void DSTR () {
		GameObject och = Instantiate(OchkiPrefab, transform.position, Quaternion.identity) as GameObject;
		och.transform.parent = transform;
		och.GetComponent<SpriteRenderer>().sortingOrder = 3;
		GameObject gm1 = Instantiate(PrefabBrt, transform.position, Quaternion.identity) as GameObject;
		GameObject gm2 = Instantiate(PrefabBrt, transform.position, Quaternion.identity) as GameObject;
		GameObject gm3 = Instantiate(PrefabBrt, transform.position, Quaternion.identity) as GameObject;
		GameObject gm4 = Instantiate(PrefabBrt, transform.position, Quaternion.identity) as GameObject;

		gm1.GetComponent<Rigidbody2D>().AddForce(Vector2.up * Force);
		gm1.GetComponent<Rigidbody2D>().AddForce(Vector2.right * Force);

		gm2.GetComponent<Rigidbody2D>().AddForce(Vector2.up * Force);
		gm2.GetComponent<Rigidbody2D>().AddForce(Vector2.right * -Force);

		gm3.GetComponent<Rigidbody2D>().AddForce(Vector2.up * -Force);
		gm3.GetComponent<Rigidbody2D>().AddForce(Vector2.right * Force);

		gm4.GetComponent<Rigidbody2D>().AddForce(Vector2.up * -Force);
		gm4.GetComponent<Rigidbody2D>().AddForce(Vector2.right * -Force);
		goTim = 1;
	}
}
