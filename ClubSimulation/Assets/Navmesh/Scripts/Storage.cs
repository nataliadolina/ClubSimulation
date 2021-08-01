using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [SerializeField] private Transform pointsParent;
    public static Transform[] points { get; private set; }

    [SerializeField] private Transform agentsParent;
    public static Transform[] agents { get; private set; }

    private void Awake()
    {
        points = pointsParent.GetComponentsInChildren<Transform>();
        agents = agentsParent.GetComponentsInChildren<Transform>();
    }
}
