using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color errorColor;

    public Vector3 positionOffset;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;
    [Header("Optional")]
    public GameObject turret;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        
        if (buildManager.CanBuild)
        {
            return;
        }

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("Cant build here");
            return;
        }
        buildManager.BuildTurretOn(this);
        rend.material.color = Color.black;
    }


}
