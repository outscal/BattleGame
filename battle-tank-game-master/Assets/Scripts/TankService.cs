using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    public TankView redTankView;
    public TankView blueTankView;
    public TankView greenTankView;

    public GameObject bullet_red;
    public GameObject bullet_blue;
    public GameObject bullet_green;

    public float speed  ;
    public TankModel tankModel;
    //public TankView tankView;
    //public Rigidbody rb;

    public void Update()
    {
        //rb = GetComponent<Rigidbody>();


        if (Input.GetKeyDown(KeyCode.M))
        {
            //Debug.Log("Red Tank");
            TankModel model = new TankModel(0.05f, 100f);
            TankController tank = new TankController(model, redTankView);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            //Debug.Log("Blue Tank");
            TankModel model = new TankModel(.02f, 50f);
            TankController tank = new TankController(model, blueTankView);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            //Debug.Log("Green Tank");
            TankModel model = new TankModel(.1f, 200f);
            TankController tank = new TankController(model, greenTankView);
        }

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



    }


    /*
    public static void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement);
    }
    */
}

    
