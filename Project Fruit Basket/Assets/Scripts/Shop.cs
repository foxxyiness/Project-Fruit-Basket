using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Turret 1 Purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchasedUpgradedTurret()
    {
        Debug.Log("Turret 2 Purchased");
        buildManager.SetTurretToBuild(buildManager.UpgradedTurretPrefab);
    }

}
