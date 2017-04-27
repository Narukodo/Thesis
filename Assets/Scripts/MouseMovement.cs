using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
	private Vector3 pos = Input.mousePosition;

	public GameObject goTerrain;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(1)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (goTerrain.collider.Raycast (ray, out hit, Mathf.Infinity)) {
				transform.position = hit.point;
			}
		}
	}
}
