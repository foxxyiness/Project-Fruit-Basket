using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 positionOffset;

    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;   
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Cant build here");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        Quaternion spawnRotation = Quaternion.Euler(-90f, 0f, 0f);
        turret =  (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, spawnRotation);
    }


}
