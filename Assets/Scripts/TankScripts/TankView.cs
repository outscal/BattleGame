﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Rigidbody))]
public class TankView : MonoBehaviour , IDamagable
{
    //public Vector3 prefabPosition;
    public float tankSpeed;
    public BulletView bulletView;
    private TankController tankController;
    public static int enemies_killed;
    //private Image image;
    //[SerializeField]
    //private List<TankState> tankStates;

    [SerializeField]
    public TankPatrollingState patrollingState;
    public TankChasingState chasingState;
    public TankAttackingState attackingState;

    [SerializeField]
    private TankState startingState;
    private TankState currentState;

    private void Awake()
    {
        
    }
    void Start()
    {
        
        tankSpeed = TankModel.Speed;
        ChangeState(startingState);
    }

    public void Update()
    {
        
        Movement();
        FireBullet();
        
        Position = this.transform.position;
    }

    private void FireBullet()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Fire");
            tankController.Fire();
        }
    }

    private void Movement()
    {

        if (gameObject.tag != "Enemy")
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

        }
    }

    public void TakeDamage(float damage)
    {
        enemies_killed++;
        Debug.Log("Damage Caused: " + damage);
        Destroy(gameObject);
        tankController.ApplyDamage(damage);

    }

    public void InitTankController(TankController controller)
    {
        this.tankController = controller;
    }

   

    public void ChangeState(TankState newState)
    {
        //if(gameObject.tag=="Enemy")
        //{

            if (currentState != null)
            {
                currentState.OnExitState();
            }
            currentState = newState;
            currentState.OnEnterState();

        //}
    }
    
    public static Vector3 Position { get; set; }
}