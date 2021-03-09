using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] waypoints;

    public void Awake()
    {
        waypoints = new Transform[transform.childCount];
        for (int i = 0; i < waypoints.Length; i++)
        {
            transform.GetChild(i);
        }

    }
}
