using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int teleports;
    [SerializeField]
    float myVelocity = .1f;
    public TeleportManager teleporter;
    public bool selectingPortal;

    // Use this for initialization
    void Start()
    {
        teleports = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * myVelocity);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.forward * -myVelocity);
        }
    }
}
