using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	public string jugarkike;
	public string jugarcarmen;


	public void kike () {
		Application.LoadLevel (jugarkike);
	}
	
	public void carmen () {
		Application.LoadLevel (jugarcarmen);
	}
	
	
}