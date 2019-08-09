using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    public BulletView prefab;
    public BulletController(/*BulletModel bulletModel,*/BulletView bulletPrefab)
    {
        //BulletModel = bulletModel;
        //prefab = bulletPrefab;
        //if(TankView.fire)
        {
            BulletView = GameObject.Instantiate<BulletView>(bulletPrefab);
            Debug.Log("Bullet");
          // 
        }
    }

    public void Fire()
    {
        Debug.Log("Fire");
        GameObject.Instantiate<BulletView>(prefab);
    }
    

    public BulletModel BulletModel { get; }
    public BulletView BulletView { get; }
}
