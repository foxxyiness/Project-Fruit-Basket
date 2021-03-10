using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 positionOffset;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }
    void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        rend.material.color = hoverColor;
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
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

        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("Cant build here");
            return;
        }
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        Quaternion spawnRotation = Quaternion.Euler(-90f, 0f, 0f);
        turret =  (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, spawnRotation);
    }


}
