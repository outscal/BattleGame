using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]
public class TankView : MonoBehaviour , IDamagable
{
    public Vector3 prefabPosition;
    //private BulletController bulletController;
    public float tankSpeed;
    public BulletView bulletView;
    private TankController tankController;

    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        tankSpeed = TankModel.Speed;
    }

    public void Update()
    {
        
        #region Movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(tankSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, tankSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1 * tankSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * tankSpeed, 0, 0);
        }
        #endregion

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Fire");
            tankController.Fire();
        }

        prefabPosition = FindObjectOfType<TankView>().transform.position;
        Position = prefabPosition;
    }
    
    public void TakeDamage(float damage)
    {
        tankController.Damage(damage);
        Debug.Log("Damage Caused: "+damage);
    }

    public void InitTankController(TankController controller)
    {
        this.tankController = controller;
    }
    
    public static Vector3 Position { get; set; }
}