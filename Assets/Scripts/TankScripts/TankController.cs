using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public TankController(TankModel tankModel,TankView tankPrefab)
    {
        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        TankModel = tankModel;
        
        //Debug.Log("Tank Type"+TankType.);
        //TankView.Speed = tankModel.Speed;
        //TankView.Health = tankModel.Health;
        //TankView.Type = tankModel.Type;
    }

    public TankModel TankModel { get;  }
    public TankView TankView { get; }
    
    
}
