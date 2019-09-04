using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
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

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.GetComponent<IDamagable>()!=null)
        {
            Debug.Log("Collision");
            IDamagable damagable = collider.GetComponent<IDamagable>();
            damagable.TakeDamage(bulletController.BulletModel.Damage);
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
            //score++;
        }
    }


    void Update()
    {
        transform.Translate(transform.forward * bulletSpeed * Time.deltaTime);
        Debug.Log(bulletSpeed);
        Destroy(gameObject, 5f);
    }

    public void DestroyBullet()
    {
        Destroy(gameObject,2f);
    }

    public void InitBulletController(BulletController controller)
    {
        this.bulletController = controller;
    }

    public BulletController BulletController { get; set; }
}
