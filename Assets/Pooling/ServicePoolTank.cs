using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePoolTank : ServicePool<TankController>
{
    public TankModel tankModel;
    public TankView tankView;
    /*
    public TankController GetTank(TankModel tankModel,TankView tankPrefab)
    {
        this.tankView = tankPrefab;
        this.tankModel = tankModel;
        TankController getTank = GetPoolItem();
        if (getTank != null)
        {
            getTank.ResetController(tankModel);
            return getTank;
        }
        return GetPoolItem();
    }
    
    protected override TankController CreateItem()
    {
        TankController tankController = new TankController(tankModel,tankPrefab);
        return tankController;
    }
    */
}
