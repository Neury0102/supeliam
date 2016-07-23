using UnityEngine;
using System.Collections;

public class ActualizarValoresGameOver : MonoBehaviour {

	public TextMesh total;
	public TextMesh record;
	public Puntuacion puntuacion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable(){
		record.text= puntuacion.puntuacion.ToString ();
		total.text =EstadoJuego.estadoJuego.puntuacionMaxima.ToString ();
	}
}
