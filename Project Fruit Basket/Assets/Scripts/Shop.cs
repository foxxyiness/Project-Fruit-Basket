using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    public TurretBlueprint defaultTurret;
    public TurretBlueprint upgradeTurret;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Turret 1 Selected");
        buildManager.SetTurretToBuild(defaultTurret);
    }

    public void UpgradedTurret()
    {
        Debug.Log("Turret 2 Selected");
        buildManager.SetTurretToBuild(upgradeTurret);
    }

}
