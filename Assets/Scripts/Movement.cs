using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float rotationDamping = 20f;
	public float runSpeed = 0.2f;
	public float turnSpeed = 50f;

//	float moveSpeed;
	private Animator anim;

	CharacterController controller;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		controller = (CharacterController)GetComponent (typeof(CharacterController));
	
	}

	void UpdateMovement(){
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		anim.SetFloat ("speed", Mathf.Abs(z));

		Vector3 inputV = new Vector3 (x, 0, z);

		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
			transform.Translate (inputV * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			transform.Translate (inputV * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
		}
	}

	// Update is called once per frame
	void Update () {
		UpdateMovement ();
	}
}

//		insert in UpdateMovement
//		if (inputV != Vector3.zero) {
//			transform.rotation = Quaternion.Slerp (transform.rotation, 
//				Quaternion.LookRotation (inputV),
//				Time.deltaTime * rotationDamping);
//		}
//		return inputV.magnitude;
