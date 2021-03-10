using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one build manager :(");
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject UpgradedTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject _turret)
    {
        turretToBuild = _turret;
    }
}
