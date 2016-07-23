using UnityEngine;
using System.Collections;

public class BotonPlay : MonoBehaviour {

	// Use this for initialization

	public string esena;
	private bool blokeado;

	void Start()
	{
		blokeado = false;
	}

	void OnMouseDown(){
		//Debug.Log ("click");
		if (esena != null){
				if (!blokeado) {
				blokeado = true;
				Application.LoadLevel(esena);
			}
		}
	}
}
