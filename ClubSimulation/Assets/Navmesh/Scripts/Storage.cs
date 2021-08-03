using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [SerializeField] private Transform pointsParent;
    public static Vector3[] points { get; private set; }

    [SerializeField] private Transform agentsParent;
    public static Vector3[] agents { get; private set; }

    private void Awake()
    {
        points = GenerateArray(pointsParent.GetComponentsInChildren<Transform>());
        agents = GenerateArray(agentsParent.GetComponentsInChildren<Transform>());
    }

    private Vector3[] GenerateArray(Transform[] transforms)
    {
        Vector3[] res = new Vector3[transforms.Length];
        for (int i = 0; i < transforms.Length; i++)
        {
            res[i] = transforms[i].position;
        }
        return res;
    }
}
