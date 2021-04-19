﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AGENTMANAGER: MonoBehaviour
{
    GameObject[] agents;
    // Use thisfor initialization
    void Start () {
        agents= GameObject.FindGameObjectsWithTag("ai");
    }
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
            {
                foreach(GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }

}

