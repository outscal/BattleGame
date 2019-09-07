using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public Vector3 currentPosition;
    public TankController(TankModel tankModel,TankView tankPrefab)
    {
        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        TankModel = tankModel;
        TankView.InitTankController(this);
        //Debug.Log("Tank Type"+TankType.);
        //TankView.Speed = tankModel.Speed;
        //TankView.Health = tankModel.Health;
        //TankView.Type = tankModel.Type;
    }

    public void ApplyDamage(float damage)
    {
        if (TankModel.Health - damage <= 0)
        {
            Debug.Log("Activate Dead State");
        }
        else
        {
            TankModel.Health -= damage;
        }
    }
    
    public void SetPosition()
    {
        currentPosition = TankView.transform.position;
        
    }
    
    public void Fire()
    {
        BulletController bulletController = BulletService.Instance.SpawnBulletType();
        Vector3 Bullet_position = TankView.transform.position + new Vector3(0f,1.2f,3f);
        bulletController.SetPosition(Bullet_position, TankView.transform.rotation);
    }

    public TankModel TankModel { get;  }
    public TankView TankView { get; }
    
}
