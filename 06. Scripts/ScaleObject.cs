using UnityEngine;
using System.Collections;

public class ScaleObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
		transform.localScale += new Vector3 (0.01F, 0.01F, 0.01F);
	}
}
