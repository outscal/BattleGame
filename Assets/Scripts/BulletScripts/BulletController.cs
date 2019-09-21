using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    public TankController tankController;
    public BulletView bulletView;

    public BulletController(BulletModel bulletModel,BulletView bulletPrefab)
    {
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab);
        //Rigidbody instBulletRigidBody = BulletView.GetComponent<Rigidbody>();
        //instBulletRigidBody.AddForce(Vector3.forward * TankModel.BulletSpeed);
        //Debug.Log("Speed "+TankModel.Speed);
        
        BulletModel = bulletModel;
        BulletView.InitBulletController(this);
    }

    public void Collision(Collision collision)
    {
        IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
        if (damagable != null && collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision");
            damagable.TakeDamage(BulletModel.Damage);
            bulletView.DestroyBullet();
            //Destroy(collision.gameObject);
            
            //score++;
        }
    }


    public void SetPosition(Vector3 transform, Quaternion rotation)
    {
        BulletView.transform.position = transform;
        BulletView.transform.rotation = rotation;
    }

    public BulletModel BulletModel { get; set; }
    public BulletView BulletView { get; set; }
}
