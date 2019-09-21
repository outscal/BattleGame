using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private TankChasingState tankChasingState;
    private int lifes_left;
    public Text scoreText;
    void Start()
    {
        tankChasingState = GetComponent<TankChasingState>();
    }

    void Update()
    {
        
        //Debug.Log(TankChasingState.life);
        scoreText.text ="Life left " + TankChasingState.life.ToString();
    }
}
