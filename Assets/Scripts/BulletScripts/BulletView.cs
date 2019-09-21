using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BulletView : MonoBehaviour , IDamagable
{
    public static int score;
    public float bulletSpeed;
    public float bulletDamage;

    public BulletController bulletController;
    private void Start()
    {
        score = 0;
        bulletSpeed = BulletModel.Speed;
    }

    public void TakeDamage(float damage)
    {
        Destroy(this.gameObject);
        Debug.Log("Damage Caused: " + damage);
    }

    void Update()
    {
        transform.Translate(transform.forward * bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 5f);
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.GetType() ==typeof (BoxCollider))
        //{
            Debug.Log("Enemy Attacked");
            bulletController.Collision(collision);
        //}
    }

    public void InitBulletController(BulletController controller)
    {
        this.bulletController = controller;
    }
    
    public BulletController BulletController { get; set; }
}
