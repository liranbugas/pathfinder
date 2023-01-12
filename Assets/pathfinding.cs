using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class pathfinding : MonoBehaviour
{
    [SerializeField]
    private Transform destPoint;
    public Transform[] destinations;
    
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    private int index=0;
   private void awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        destPoint = destinations[index];
    }

    // Update is called once per frame
    private void Update()
    {
        if(navMeshAgent.destination == destPoint.position)
        {
            index++;
            destPoint = destinations[index];
            
        }
        else
        {

        }
        navMeshAgent.destination = destPoint.position;
    }
}
