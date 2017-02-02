using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float moveSpeed = 15.0f;
    private Rigidbody rB;

	// Use this for initialization
	void Start () {
        rB = this.GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rB.AddForce(Vector3.forward * moveSpeed, ForceMode.Impulse);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}

}
