using UnityEngine;
using System.Collections;

public class PuntoBloque : MonoBehaviour {


	private bool collicionoConElJugador= false;
	public int PuntosIncremento=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		//Debug.Log(collision.collider.gameObject.name);
		if (!collicionoConElJugador && (collision.collider.gameObject.name == "pierna_2" || collision.collider.gameObject.name == "piernaIzquierda")) {
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", PuntosIncremento);
			collicionoConElJugador = true;
		}
	}
	/*
	void OnCollisionEnter2D(Collision2D collision)
	{

		if (!collicionoConElJugador&& collision.gameObject.tag == "Player") {
				collision.contacts
			collicionoConElJugador=true;
			NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos",PuntosIncremento);
	    	}

	}*/
}
