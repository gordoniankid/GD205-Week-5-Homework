using UnityEngine;
using System.Collections;

public class Hungry : MonoBehaviour {
	public GameObject fishPellet;
	public float howHangry;
	bool hungry;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		hungry = true;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 destination = fishPellet.transform.position;
		Vector3 direction = Vector3.Normalize (destination - transform.position);
		
		//Debug.Log ("direction of food:  " + direction);

		if (hungry) {
			GetComponent<Rigidbody> ().AddForce (direction * howHangry);


		} else {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;

		}

        if(Input.GetMouseButtonDown(0))
        {

            Instantiate(fishPellet, transform.position, transform.rotation);
 


        }

	}



	void OnCollisionEnter(Collision col) {
		//Debug.Log ("fishie hit ... " + col.gameObject);
		if (col.gameObject == fishPellet)
        {
            Destroy(col.gameObject);
            hungry = false;
            
        } 
	}

}

