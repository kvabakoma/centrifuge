using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    public int index = 0;
    public Material selectMat;
    public Material deSelectMat;
    public Material grey;
    public MeshRenderer rend;
    public TeleportManager teleporter;

    public void HighLightPortal()
    {
        rend.material = selectMat;
    }

    internal void DeselectPortal()
    {
        rend.material = deSelectMat;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "hero")
        {
            rend.material = grey;
            teleporter.StartSelection(index);
            Debug.Log(gameObject.name);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        Debug.Log("2");
        rend.material = deSelectMat;
        teleporter.EndSelection();
    }
}
