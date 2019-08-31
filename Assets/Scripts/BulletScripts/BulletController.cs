using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    public TankController tankController;
    public BulletView bulletPrefab;

    public BulletController(BulletModel bulletModel,BulletView bulletPrefab)
    {
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab, TankView.Position + new Vector3(0,1,2),Quaternion.identity);
        Rigidbody instBulletRigidBody = BulletView.GetComponent<Rigidbody>();
        instBulletRigidBody.AddForce(Vector3.forward * TankModel.BulletSpeed);
        //BulletView.DestroyBullet();
        Debug.Log("Bullet Spawned");
        BulletModel = bulletModel;
    }

    public void Fire()
    {
        Debug.Log("Fire");
    }
    

    public BulletModel BulletModel { get; }
    public BulletView BulletView { get; }
}
