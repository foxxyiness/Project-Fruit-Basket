using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    public TurretBlueprint defaultTurret;
    public TurretBlueprint upgradeTurret;
    public TextMeshProUGUI turretStatus;

    void Start()
    {
        buildManager = BuildManager.instance;
        turretStatus.text = "";
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Turret 1 Selected");
        turretStatus.text = "Default Turret Selected";
        buildManager.SetTurretToBuild(defaultTurret);
    }

    public void UpgradedTurret()
    {
        Debug.Log("Turret 2 Selected");
        turretStatus.text = "Big Mama Turret Selected";
        buildManager.SetTurretToBuild(upgradeTurret);
    }

}
