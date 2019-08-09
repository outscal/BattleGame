using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    private static TankService instance;
    public TankService Instance {  get { return instance; } } 

    public TankView redTankView;
    public TankView blueTankView;
    public TankView greenTankView;

    public BulletView bulletPrefab;
    
    public float speed;
    public BulletService bulletService;

    public void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        bulletService = GetComponent<BulletService>();
    }

    public void Update()
    {
        //rb = GetComponent<Rigidbody>();

        SpawnTank();
        SpawnBullets();
        
    }

    void SpawnTank()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            TankModel model = new TankModel(0.05f, 100f, 5f, 100f);
            TankController tank = new TankController(model, redTankView);
            bulletPrefab = bulletService.redBulletView;
            BulletModel bulletModel = new BulletModel(5f, 100f);
            //BulletController bulletController = new BulletController(bulletModel,bulletService.redBulletView);

        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            TankModel model = new TankModel(.02f, 50f, 5f, 100f);
            TankController tank = new TankController(model, blueTankView);
            BulletModel bulletModel = new BulletModel(15f, 50f);
            bulletPrefab = bulletService.blueBulletView;
            //BulletController bulletController = new BulletController(bulletModel, bulletService.blueBulletView);

        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            TankModel model = new TankModel(.1f, 200f, 5f, 100f);
            TankController tank = new TankController(model, greenTankView);
            BulletModel bulletModel = new BulletModel(52f, 25f);
            bulletPrefab = bulletService.greenBulletView;
            //BulletController bulletController = new BulletController(bulletModel, bulletService.greenBulletView);

        }
    }

    public void SpawnBullets()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            BulletController bulletController = new BulletController(bulletPrefab);
        }
    }
}
        /*
        #region Firing 
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (redTankView)
            {


                foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
                {
                    //var currentPosition = GameObject.Find("TankRed(Clone)");
                    if (gameObj.name == "TankRed(Clone)")
                    {
                        var currentPosition = gameObj.transform.position;
                        //Debug.Log("Red Tank Pos. " + currentPosition);
                        GameObject inst_bullet = Instantiate(bullet_red, currentPosition + new Vector3(0, 1, 1), Quaternion.identity) as GameObject;
                        //transform.position = redTankView.transform.position;
                        Rigidbody instBulletRigidBody = inst_bullet.GetComponent<Rigidbody>();
                        instBulletRigidBody.AddForce(Vector3.forward * speed);
                        Destroy(inst_bullet, 3f);
                    }
                    
                }


                //var currentPosition = GameObject.Find("TankRed(Clone)");
                

                

            }
            if (blueTankView)
            {
                foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
                {
                    //var currentPosition = GameObject.Find("TankRed(Clone)");
                    if (gameObj.name == "TankBlue(Clone)")
                    {
                        var currentPosition = gameObj.transform.position;
                        //Debug.Log("Blue Tank Pos. " + currentPosition);
                        GameObject inst_bullet = Instantiate(bullet_blue, currentPosition + new Vector3(0, 1, 1), Quaternion.identity) as GameObject;
                        //transform.position = redTankView.transform.position;
                        Rigidbody instBulletRigidBody = inst_bullet.GetComponent<Rigidbody>();
                        instBulletRigidBody.AddForce(Vector3.forward * speed);
                        Destroy(inst_bullet, 3f);
                    }

                }


            }

            if (greenTankView)
            {
                foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
                {
                    //var currentPosition = GameObject.Find("TankRed(Clone)");
                    if (gameObj.name == "TankGreen(Clone)")
                    {
                        var currentPosition = gameObj.transform.position;
                        //Debug.Log("Blue Tank Pos. " + currentPosition);
                        GameObject inst_bullet = Instantiate(bullet_green, currentPosition + new Vector3(0, 1, 1), Quaternion.identity) as GameObject;
                        //transform.position = redTankView.transform.position;
                        Rigidbody instBulletRigidBody = inst_bullet.GetComponent<Rigidbody>();
                        instBulletRigidBody.AddForce(Vector3.forward * speed);
                        Destroy(inst_bullet, 3f);
                    }

                }
            }

        }
        #endregion
        */


    


    /*
    public static void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement);
    }
    */


    
