using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {


	public int puntuacion=0;
	public TextMesh MarcadorPuntos;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeAMuerto");
		
		ActualizarMarcadorPuntos ();
	}

	void PersonajeAMuerto(Notification notificacion)
	{
		if (puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima) {
						//Debug.Log ("puntuacion maxima superada maxima " + EstadoJuego.estadoJuego.puntuacionMaxima + "actual" + puntuacion);
						EstadoJuego.estadoJuego.puntuacionMaxima=puntuacion;
						EstadoJuego.estadoJuego.Guardar ();
				} else {
					//Debug.Log("recor no superado " + EstadoJuego.estadoJuego.puntuacionMaxima + "actual" + puntuacion);
					
				}

		}
	void IncrementarPuntos(Notification notificacion)
	{
		int puntoAIncrementar = (int)notificacion.data;
		puntuacion +=puntoAIncrementar;
		ActualizarMarcadorPuntos ();
	}

	void ActualizarMarcadorPuntos()
	{
		MarcadorPuntos.text = puntuacion.ToString ();
		}
	// Update is called once per frame
	void Update () {
	
	}

}
