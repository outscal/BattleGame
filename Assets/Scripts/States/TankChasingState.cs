using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankChasingState : TankState
{
    //[SerializeField]
    //private Color differentColor;
    private TankPatrollingState tankPatrollingState;
    private float rotationSpeed = 3f;
    private float moveSpeed = 3f;
    private EnemyScript enemyScript;
    private PlayerScript playerScript;
    private bool stateActive = false;
    private Vector3 playerPos;
    public static int life = 3;

    public override void OnEnterState()
    {
        base.OnEnterState();
        stateActive = true;
        Debug.Log("Entering Chasing State");
        //tankView.ChangeColor(differentColor);
    }


    public override void OnExitState()
    {
        base.OnExitState();
        stateActive = false;
        Debug.Log("Exiting Chasing state");

    }

    private void Start()
    {
        enemyScript = GetComponent<EnemyScript>();
        playerScript = GetComponent<PlayerScript>();
        life = 3;
    }

    private void Update()
    {
        if(stateActive)
        {
            //Debug.Log(playerScript.transform.position);
            //playerPos = playerScript.transform.position;
            if(enemyScript)
            {

                this.transform.rotation = Quaternion.Slerp(this.transform.rotation
                                                      , Quaternion.LookRotation(GameObject.FindGameObjectWithTag("Player").transform.position - this.transform.position)
                                                     , rotationSpeed * Time.deltaTime);
                this.transform.position += transform.forward * moveSpeed * Time.deltaTime;

            }
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(enemyScript && collision.gameObject.name!="Plane")
        {
            Destroy(collision.gameObject);
            if(collision.gameObject.tag=="Player")
            {
                life--;
                Debug.Log("Life " + life);
            }
        }
    }

}
