using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Agent : MonoBehaviour
{
    protected Vector3[] aims = null;
    protected NavMeshAgent navMeshAgent;

    private float stoppingDist = 0f;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        stoppingDist = navMeshAgent.stoppingDistance;
        SetAims();

        SetNewAim();
    }

    protected abstract void SetAims();

    private void Update()
    {
        if (navMeshAgent.remainingDistance <= stoppingDist)
        {
            SetNewAim();
        }
    }

    protected virtual void SetNewAim()
    {
        var currentAim = aims[Random.Range(0, aims.Length)];
        navMeshAgent.destination = currentAim;
    }
}
