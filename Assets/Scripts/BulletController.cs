using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    public TankController tankController;

    public BulletController(BulletView bulletPrefab)
    {
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab, TankController.Position + new Vector3(0,1,2),Quaternion.identity);
        Rigidbody instBulletRigidBody = BulletView.GetComponent<Rigidbody>();
        instBulletRigidBody.AddForce(Vector3.forward * TankModel.BulletSpeed);
        BulletView.DestroyBullet();
    }

    //public void Fire()
    //{
    //    Debug.Log("Fire");
    //    GameObject.Instantiate<BulletView>(prefab);
    //}
    

    public BulletModel BulletModel { get; }
    public BulletView BulletView { get; }
}
