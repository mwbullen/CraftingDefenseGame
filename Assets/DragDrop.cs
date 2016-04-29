using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Drag() {
		transform.position = Input.mousePosition;
	}
}
