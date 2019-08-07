using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    public BulletController(BulletModel bulletModel,BulletView bulletPrefab)
    {
        BulletModel = bulletModel;
        //Debug.Log("Instantiate Bullet before",BulletView);
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab);
        //Debug.Log("Instantiate Bullet after",BulletView);
    }

    public BulletModel BulletModel { get; }
    public BulletView BulletView { get; }
}
