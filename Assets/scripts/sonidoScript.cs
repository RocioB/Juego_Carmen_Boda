using UnityEngine;
using System.Collections;

public class sonidoScript : MonoBehaviour {
	public AudioClip cancion;
	// Use this for initialization

void OnTriggerEnter2D(Collider2D player){
	
	AudioSource.PlayClipAtPoint(cancion,transform.position);

	}
}