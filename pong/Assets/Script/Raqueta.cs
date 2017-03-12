using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Raqueta : MonoBehaviour 
{

	Vector2 raquetaTras;
	public int player;
	float factorVel;

	// Use this for initialization
	//se inician las condiciones de la raqueta
	void Start () 
	{
		raquetaTras = new Vector2(0.0f,0.0f);
		factorVel = 20.0f;	
	}
	
	// Update is called once per frame

	//se indica que utilizando las teclas direccionales: arriba y abajo, y las teclas WS, se controla la raqueta para el jugar 1 o jugador 2
	void Update () 
	{
		raquetaTras.y = 0.0f;


		//al pulsar R se reinicia la escena del juego
		if(Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		if(player == 1)
		{
			if(Input.GetKey(KeyCode.UpArrow))
			{
				raquetaTras.y = factorVel * Time.deltaTime;
				transform.Translate(raquetaTras);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				raquetaTras.y = -1*factorVel * Time.deltaTime;
				transform.Translate(raquetaTras);
			}
		}

		if (player == 2)
		{
			if(Input.GetKey(KeyCode.W))
			{
				raquetaTras.y = factorVel * Time.deltaTime;
				transform.Translate(raquetaTras);
			}
			if(Input.GetKey(KeyCode.S))
			{
				raquetaTras.y = -1*factorVel * Time.deltaTime;
				transform.Translate(raquetaTras);
			}
		}
	}
}

