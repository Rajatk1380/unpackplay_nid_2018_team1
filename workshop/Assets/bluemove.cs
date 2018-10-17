
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluemove : MonoBehaviour {

	// Use this for initialization

		public float moveSpeed = 5f;
		private Rigidbody2D rb2d;
	
	
	// Update is called once per frame
	//void Start()
	//{
	//	rb2d=
	//}
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (-Vector2.left* moveSpeed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.left * moveSpeed * Time.deltaTime);

		} else 
		{
			
		}
	}
}
