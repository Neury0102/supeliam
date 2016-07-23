using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int PuntosGanados=5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		//Debug.Log ("Item tocado por el Liam");
		if (collider.tag == "Player") {
						NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", PuntosGanados);
				}
		Destroy (gameObject);
	}
}
