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

    public override void OnEnterState()
    {
        base.OnEnterState();
        //tankView.ChangeColor(differentColor);
    }


    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exiting Chasing state");

    }

    private void Update()
    {
        if(gameObject.tag=="Enemy")
        {

            transform.rotation = Quaternion.Slerp(transform.rotation
                                                  , Quaternion.LookRotation(tankPatrollingState.player.position - transform.position)
                                                  , rotationSpeed * Time.deltaTime);

            
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

        }
    }

}
