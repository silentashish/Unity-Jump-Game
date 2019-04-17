using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour {

	public Rigidbody2D rd;



	// Use this for initialization
	void Start () {

		rd=GetComponent<Rigidbody2D>();


	}

	// Update is called once per frame
	void Update () {
		rd.velocity = new Vector2 (1, rd.velocity.y);

		if (Input.GetMouseButtonDown (0)) {
			rd.velocity = new Vector2 (rd.velocity.x, 10);
		}








	}
}
