using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TankView : MonoBehaviour , IDamagable
{
    public Vector3 prefabPosition;
    private BulletController bulletController;
    //private Rigidbody rigidbody;
    public float tankSpeed;
    public TankScriptableObject tankScriptableObject;
    public BulletView bulletView;
    public TankController tankController;

    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        tankSpeed = TankModel.Speed;
    }

    public void Update()
    {
        //SpawnBullets(BulletModel bulletPrefab);

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


    public void SpawnBullets(BulletModel bulletPrefab)
    {
         if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Fire");
            tankcontroller.Fire();
        }
        //BulletController bulletController = new BulletController(bulletPrefab,bulletView/*,Position,Quaternion.identity*/);
        //Destroy(bulletController, 2f);


    }

    public void TakeDamage(float damage)
    {
        tankController.Damage(damage);
        
    }

    
    public static Vector3 Position { get; set; }
}