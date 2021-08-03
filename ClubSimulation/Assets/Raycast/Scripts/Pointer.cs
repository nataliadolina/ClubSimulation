using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public static Vector3[] currentPoint;

    private Transform pointToMove = null;

    void Awake()
    {
        currentPoint = new Vector3[1];
        pointToMove = GetComponentInChildren<Transform>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (hit.collider.CompareTag("Ground"))
                    {
                        currentPoint[0] = hit.point;
                        pointToMove.position = hit.point;
                    }
                }
            }
        }
    }
}
