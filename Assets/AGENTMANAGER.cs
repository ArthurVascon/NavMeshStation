using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AGENTMANAGER: MonoBehaviour
{
//Todos os Agents presente no mapa
    GameObject[] agents;
    // Use thisfor initialization
    void Start () {
        agents= GameObject.FindGameObjectsWithTag("ai");
    }
    // Update is called once per frame
    void Update () {
//Apertar o botão do mouse
        if(Input.GetMouseButtonDown(0)) 
        {
//Ele vai ver onde clicou, vai chamar o AI Control e vai setar o destino para lá.
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
            {
                foreach(GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }

}

