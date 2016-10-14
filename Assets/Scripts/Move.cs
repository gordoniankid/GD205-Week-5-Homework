using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject textThing;

	bool hasKey;

	public Vector3[] verboten;
	Vector3 startPos;


	// Use this for initialization
	void Start () {
		hasKey = false;

		startPos = new Vector3 (0,0,0);
		transform.position = startPos; //set the initial players position
		textThing.GetComponent<TextMesh> ().text = "You are in the starting position.";
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("up")) {
			Debug.Log ("Someone just pressed up.");
			transform.position += new Vector3(0,0,1);
		}

		if (Input.GetKeyDown ("down")) {
			transform.position += new Vector3(0,0,-1);
		}

		if (Input.GetKeyDown ("left")) {
			transform.position += new Vector3(-1,0,0);
		}

		if (Input.GetKeyDown ("right")) {
			transform.position += new Vector3(1,0,0);
		}



		textThing.GetComponent<TextMesh> ().text = "You are in pos (" + transform.position.x + ", "+ transform.position.z + ")";

		//lets check the players position against all the forbidden positions
		for (int i = 0; i < verboten.Length; i++){

			//if the player position is the same as any of the positions in the list (cycled with i)...
			if (transform.position == verboten [i]) {

				//send a console message saying "you ded"
				Debug.Log ("you ded");
				//reset the players position to whatever startPos is
				transform.position = startPos;
			}
		}


	}
}
