using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

		
		public float jumpSpeed = 5f;
		public bool standing;
		public GameObject groundCheck;
		
		private Animator animator;
		
		
		void Start () {
			
			animator = GetComponent <Animator> ();
			
		}
		// Update is called once per frame
		void Update () {
			var absVelY = Mathf.Abs(rigidbody2D.velocity.y);
			if(absVelY <= .05f){
				standing = true;
			}else{
				standing = false;
			}
			
			if( (Input.GetKeyDown("up") || Input.GetKeyDown("space")) && standing){
				rigidbody2D.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
			}
			
			var VelY = rigidbody2D.velocity.y;
			if (absVelY > 0)
				animator.SetFloat ("salto", absVelY);
		}
	}
	
