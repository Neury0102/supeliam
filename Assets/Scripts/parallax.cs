﻿using UnityEngine;
using System.Collections;

public class parallax : MonoBehaviour {

	public bool InicialEnMovimiento = false;
	public float velocidad = 0f;
	private bool enMovimiento = false;
	private float tiempoInicio =0f;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeEmpiezaACorrer");
		NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeAMuerto" );
		if (InicialEnMovimiento) {
			PersonajeEmpiezaACorrer();
		}
	}
	void PersonajeAMuerto()
	{
		enMovimiento = false;
	}
	void PersonajeEmpiezaACorrer()
	{
		enMovimiento = true;
		tiempoInicio = Time.time; 
	}
	// Update is called once per frame
	void Update () {
		if(enMovimiento)
		{
			renderer.material.mainTextureOffset = new Vector2 (((Time.time- tiempoInicio) * velocidad)%1, 0);
		}
	}
}
