using UnityEngine;
using System.Collections;

public class MoveCubes : MonoBehaviour {
    public GameObject Sphere;
    public GameObject Sphere1;
    public GameObject Cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {





        if (Input.GetKeyDown("up"))
        {
            transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.position += new Vector3(0, 0, -1);
        }

        if (Input.GetKeyDown("left"))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.position += new Vector3(1, 0, 0);

        }

        if (Input.GetKeyDown("down"))
        {
            Sphere.transform.position += new Vector3(0, 0, 1);
        }

        if (Input.GetKeyDown("up"))
        {
            Sphere.transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown("left"))
        {
            Sphere.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            Sphere.transform.position += new Vector3(-1, 0, 0);
        }
    }

}

