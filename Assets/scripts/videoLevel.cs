using UnityEngine;
using System.Collections;

public class videoLevel : MonoBehaviour {

	public string nombreNivel;


	public void cargaNivel(){
				Application.LoadLevel (nombreNivel);
		}


}
