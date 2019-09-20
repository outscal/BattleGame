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
    }

    private void Update()
    {
        if(stateActive)
        {
            //Debug.Log(playerScript.transform.position);
            //playerPos = playerScript.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation
                                                  , Quaternion.LookRotation(GameObject.FindGameObjectWithTag("Player").transform.position - this.transform.position)
                                                 , rotationSpeed * Time.deltaTime);
            this.transform.position += transform.forward  * moveSpeed * Time.deltaTime; 
        }

        //        if (enemyScript)
        {
            //


            //gameObject.GetComponent<EnemyScript>().transform.position += transform.forward * moveSpeed * Time.deltaTime;
            //Debug.Log("Enemy Position"+this.transform.position);
            
        }
        /*
        if (Vector3.Distance(tankPatrollingState.player.position, gameObject.GetComponent<EnemyScript>().transform.position) > 30f)
        {
            
            Debug.Log("Change back to Patrolling State");
            tankView.ChangeState(tankView.patrollingState);
        }

        if (Vector3.Distance(tankPatrollingState.player.position, gameObject.GetComponent<EnemyScript>().transform.position) < 10f)
        {
            
            Debug.Log("Change to Attacking State");
            tankView.ChangeState(tankView.attackingState);
        }
        */
    }

}
