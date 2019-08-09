using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public float tankSpeed;
    public float tankHealth;
    public static bool fire;

    public BulletController bulletController;
    public BulletService bulletService;
    public BulletView bulletView;

    void Start()
    {
        tankSpeed = TankModel.Speed;
        fire = false;
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
        
    }
}