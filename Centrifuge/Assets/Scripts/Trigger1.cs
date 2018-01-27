using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {

    public Rigidbody obstacle;
    
    public void OnTriggerEnter(Collider col)
    {
        obstacle.useGravity = true;
    }
}
