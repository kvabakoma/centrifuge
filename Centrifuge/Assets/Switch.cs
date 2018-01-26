using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public Animator anim;
    bool isAccesable;
    bool isOn;
    // Use this for initialization
    void Start()
    {
        isAccesable = true;
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isAccesable)
        {
            Debug.Log("press");
            anim.SetTrigger("Press");
            anim.SetBool("IsOn", isOn);
            isOn = !isOn;
        }
    }
}
