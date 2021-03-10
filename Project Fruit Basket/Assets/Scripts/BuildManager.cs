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

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn(Node node)
    {
        Quaternion spawnRotation = Quaternion.Euler(-90f, 0f, 0f);
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), spawnRotation);
        node.turret = turret;
    }

    public void SetTurretToBuild(TurretBlueprint _turret)
    {
        turretToBuild = _turret;
    }
}
