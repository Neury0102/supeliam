using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {


	public Transform liam;
	public float separacion = 6f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (liam.position.x+separacion, transform.position.y, transform.position.z);
	}
}
