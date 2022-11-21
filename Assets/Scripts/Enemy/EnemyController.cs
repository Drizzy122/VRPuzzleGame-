using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform Nodes;
    NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        GetNewNode();
    }

    // Update is called once per frame
    void Update()
    {

        if (!navMeshAgent.pathPending)
        {
            if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                if (!navMeshAgent.hasPath || navMeshAgent.velocity.sqrMagnitude == 0f)
                {
                    GetNewNode();
                }
            }
        }
    }

    void GetNewNode()
    {
        Transform target = Nodes.GetChild(Random.Range(0, Nodes.childCount)).transform;
        Debug.Log(target.name);
        navMeshAgent.destination = target.position;
    }
}
