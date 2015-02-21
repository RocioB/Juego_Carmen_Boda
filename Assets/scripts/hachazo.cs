using UnityEngine;
using System.Collections;

public class hachazo : MonoBehaviour {
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)||Input.GetKey(KeyCode.RightControl)||Input.GetKey(KeyCode.LeftControl)) {
			animator.SetBool ("Hachazo", true);
			
		} else {
			animator.SetBool ("Hachazo", false);
		}
	}
}
