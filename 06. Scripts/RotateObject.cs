using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	// Use this for initialization
	public void Start () {

	}
	
	// Update is called once per frame
	public void Update () {
		transform.Rotate (new Vector3(0,Time.deltaTime*100,0));
	}
}
