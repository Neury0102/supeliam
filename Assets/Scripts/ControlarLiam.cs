using UnityEngine;
using System.Collections;

public class ControlarLiam : MonoBehaviour {
	public float FuerzaSalto=100f;
	private bool enSuelo =  true;
	public Transform comprobadorSuelo;
	private float comprobadorRadio= 0.07f;
	public LayerMask mascaraSuelo;

	private bool dobleSalto = false;

	private Animator animator;

	private bool corriendo = false;//

	public float Velocidad = 1f;//
	void Awake()
	{
		animator = GetComponent<Animator>();
		}
	// Use this for initialization//
	void Start () {
	
	}
	void FixedUpdate(){
		if (corriendo) {
			rigidbody2D.velocity = new Vector2(Velocidad,rigidbody2D.velocity.y); 	
			enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
			animator.SetBool ("EnPiso", enSuelo);
		}
		animator.SetFloat("VelocidadX", rigidbody2D.velocity.x);
		//enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		//animator.SetBool ("EnPiso", enSuelo);//
		if (enSuelo) {

			dobleSalto= false;
			}
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if (corriendo) 
			{
				//hacemos que salte si puede saltal
				if (enSuelo || !dobleSalto)
					{
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, FuerzaSalto);
						//rigidbody2D.AddForce(new Vector2(0,FuerzaSalto));
						if (!dobleSalto && !enSuelo)
						{
							dobleSalto = true;
						}
					 }
			} 
		    else 
			{
				corriendo = true;
				NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeEmpiezaACorrer");
			}
		}
	}
}
