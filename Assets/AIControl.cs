using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;
        // Use this for initialization
        void Start () {
	//Indica o NavMesh do Personagem
        agent= this.GetComponent<NavMeshAgent>();
    }
}
