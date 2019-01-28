using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

	public GameObject Baggi, WheelForward, WheelBack;
	public float speedForward;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Baggi.transform.position.x, transform.position.y, -10);

			WheelBack.GetComponent<Rigidbody2D>().AddTorque(-speedForward * Time.deltaTime);
			WheelForward.GetComponent<Rigidbody2D>().AddTorque(-speedForward * Time.deltaTime);
		

	}
}
