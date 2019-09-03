using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    public TankController tankController;
    public BulletView bulletPrefab;

    public BulletController(BulletModel bulletModel,BulletView bulletPrefab)
    {
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab);
        Rigidbody instBulletRigidBody = BulletView.GetComponent<Rigidbody>();
        instBulletRigidBody.AddForce(Vector3.forward * TankModel.BulletSpeed);
        //BulletView.DestroyBullet();
        //Debug.Log("Bullet Spawned");
        BulletModel = bulletModel;
        BulletView.InitBulletController(this);
    }

    public void Fire()
    {
        Debug.Log("Fire");
    }

    public void SetPosition(Vector3 transformArg, Quaternion rotation)
    {
        BulletView.transform.position = transformArg;
        BulletView.transform.rotation = rotation;
    }

    public BulletModel BulletModel { get; set; }
    public BulletView BulletView { get; set; }
}
