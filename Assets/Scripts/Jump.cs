using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public float jump = 300;
    public float jumpForce = 300;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
        }
    }
}
