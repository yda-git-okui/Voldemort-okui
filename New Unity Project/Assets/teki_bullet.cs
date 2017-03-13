using UnityEngine;
using System.Collections;

public class teki_bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity
		= new Vector2(0, -5.0f);
	}

	// Update is called once per frame
	void Update () {
	}
}
