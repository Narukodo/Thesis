using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player; //reference to player object
	private Vector3 offset; //holds offset value; offset = camera_transform - player_transform

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;

	}

	// LateUpdate for cameras, animation, etc. is recommended
	//runs every frame, but is guaranteed to run after all items have been processed in update
	//when LateUpdate is run, it is guaranteed that player has moved
	void LateUpdate () {
		transform.position = player.transform.position + offset; //updates position of camera according to player movement

	}
}
