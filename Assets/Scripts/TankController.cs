using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public Vector3 prefabPosition;
    public TankController(TankModel tankModel,TankView tankPrefab)
    {
        TankModel = tankModel;
        TankView = GameObject.Instantiate<TankView>(tankPrefab);

        prefabPosition = TankView.transform.position;
        Position = prefabPosition;
        Debug.Log(prefabPosition);
        //Debug.Log("Tank View Created", TankView);
    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }

    public static Vector3 Position { get; set; }
}
