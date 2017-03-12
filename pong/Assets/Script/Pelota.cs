using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Carlos Arroyave16774

public class Pelota : MonoBehaviour {


	// Use this for initialization

	//se aplica una fuerza al objeto pelota de forma aleatoria. una fuerza vertical y otra horizontal
	void Start () 
	{
		GetComponent<Rigidbody2D>().AddForce(transform.up*250);

		var rand  = Random.Range(1,10);
		
		if(rand <= 5)
		{
			GetComponent<Rigidbody2D>().AddForce(transform.right*250);
		}
		else if(rand>5)
		{
			//GetComponent<Rigidbody2D>().AddForce(-1*transform.up*300);
			GetComponent<Rigidbody2D>().AddForce(-1*transform.right*300);
		}


		
		
	}
	
	//si existe una colision contra una pared vertical, el objeto "pelota" se destruye
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "ParedIzquierda")
		{
			Destroy(this.gameObject);
		}

		if(col.gameObject.name == "ParedDerecha")
		{
			Destroy(this.gameObject);
		}

	}
}
