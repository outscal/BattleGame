using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour 
{
    //public GameObject RedTank;
    //public GameObject BlueTank;
    //public GameObject GreenTank;

    public float tankSpeed;
    public float tankHealth;

    public TankModel tankModel;

    public TankView()
    {
        //tankSpeed = tankModel.Speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Tank Created");
        tankSpeed = TankModel.Speed;
    }

    // Update is called once per frame
    public void Update()
    {
        #region Movement
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Speed "+ TankModel.inspectorSpeed);
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
