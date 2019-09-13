using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPatrollingState : TankState
{
    //private float timeElapsed;
    private TankController tankController; 
    private EnemyScript enemyScript;
    public Transform player;

    private bool dirRight = true;
    public float speed = 2.0f;
    //private TankView tankView;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //tankView = GetComponent<TankView>();
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        Debug.Log("Entering Patrolling state");
        //tankView.ChangeColor(color);
    }

    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exiting Patrolling state");

    }

    private void Update()
    {
        if(gameObject.GetComponent<EnemyScript>())
        {

            if (dirRight)
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            else
                transform.Translate(-Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= 4.0f)
            {
                dirRight = false;
            }

            if (transform.position.x <= -4.0f)
            {
                dirRight = true;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other is BoxCollider)
        {
            tankView.ChangeState(tankView.chasingState);
        }

        if (other is SphereCollider)
        {
            tankView.ChangeState(tankView.attackingState);
        }
        
        //enemyScript.Trigger(other);
    }

    public TankView TankView { get; }
}
