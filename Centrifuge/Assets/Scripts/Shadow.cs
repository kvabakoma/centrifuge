using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {
    [SerializeField]
    float myVelocity = .1f;

    private Rigidbody myRigidBody;


    // Use this for initialization
    void Start() {
        myRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.forward * myVelocity);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "goal")
        {
            Debug.Log("we lost");
        }
    }
}
