using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TankView : MonoBehaviour
{
    private TankType tankType;
    public Vector3 prefabPosition;
    //private Rigidbody rigidbody;
    public float tankSpeed;
    //public TankScriptableObject tankScriptableObject;

    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        tankSpeed = TankModel.Speed;
    }

    public void Update()
    {
        SpawnBullets();

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
        prefabPosition = FindObjectOfType<TankView>().transform.position;
        Position = prefabPosition;
    }


    public void SpawnBullets()
    {
        //if (Input.GetKeyDown(tankScriptableObject.FireKey))
        {
            //BulletController bulletController = new BulletController(bulletPrefab);
            //Destroy(bulletController, 2f);
        }
    }

    public static Vector3 Position { get; set; }
}