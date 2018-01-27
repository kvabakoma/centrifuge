using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
    [SerializeField]
    float myVelocity = .1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * myVelocity);
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.forward * -myVelocity);
        }
    }
}
