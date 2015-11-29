using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		// Dentro do IF sera criado um Botao, considerando a posiçao X, Y e as dimensoes Largura e Altura
		
		// Quando o botao for pressionado, o IF verificara que o resultado e VERDADEIRO e seu bloco sera executado

		if (GUI.Button (new Rect (700, 271, 260, 60), "INSTRUCTIONS")) {
			Application.LoadLevel(4);
		}
		
		if (GUI.Button (new Rect (700, 340, 260, 80), "PLAY GAME")) {
			Application.LoadLevel(2);
		}
		
		if (GUI.Button (new Rect (757, 430, 150, 40), "CREDITS")) {
			Application.LoadLevel(1);
		}
	}
}
