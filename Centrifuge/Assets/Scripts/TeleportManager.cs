using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public List<Portal> portals;
    public Hero player;
    public int selectedPortal;
    bool selecting;
    int startPortal;

    void Start()
    {
        portals = portals.OrderByDescending(x => x.gameObject.transform.position.y).ToList();
        for (int i = 0; i < portals.Count; i++)
        {
            portals[i].index = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (selecting)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                UpdateSelection(-1);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                UpdateSelection(1);
            }

            if(Input.GetKeyDown(KeyCode.Return))
            {
                EndSelection();
                player.transform.position = portals[selectedPortal].transform.position;
            }
        }
    }

    void UpdateSelection(int dir)
    {
        portals[selectedPortal].DeselectPortal();
        selectedPortal = findPosInDirection(dir);
        portals[selectedPortal].HighLightPortal();
    }

    internal void StartSelection(int index)
    {
        selecting = true;
        startPortal = index;
        selectedPortal = index;
        selectedPortal = findPosInDirection(1);
        portals[selectedPortal].HighLightPortal();
    }

    int findPosInDirection(int dir)
    {
        var temp = selectedPortal;
        temp += dir;
        while (temp == startPortal || temp < 0 || temp > portals.Count - 1)
        {
            temp += dir;
            if (temp < 0)
            {
                temp = portals.Count - 1;
            }
            else if (temp > portals.Count - 1)
            {
                temp = 0;
            }
        }
        return temp;
    }

    public void EndSelection()
    {
        Debug.Log("deselect " + portals[selectedPortal].gameObject.name);
        selecting = false;
        portals[selectedPortal].DeselectPortal();
    }
}
