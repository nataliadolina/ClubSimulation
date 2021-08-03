using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAgent : Agent
{
    protected override void SetAims()
    {
        aims = Pointer.currentPoint;
    }

    protected override void SetNewAim()
    {
        SetAims();
        var currentAim = aims[Random.Range(0, aims.Length)];

        if (currentAim == null)
            currentAim = transform.position;

        navMeshAgent.destination = currentAim;
    }
}
