using UnityEngine;

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Tank", menuName = "ScriptableObjects/Tank")]
public class TankScriptableObject : ScriptableObject
{
    public TankType tankType;
    //public GameObject tankBody;
    public string TankName;
    public float Speed;
    public float Health;
    public KeyCode FireKey;
}

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/TankScriptableObjectList", menuName = "ScriptableObjects/Tank Lists")]
public class TankScriptableObjectList : ScriptableObject
{
    public TankScriptableObject[] tanks;
}