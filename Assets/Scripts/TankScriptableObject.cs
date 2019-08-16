using UnityEngine;

[CreateAssetMenu(fileName = "Assets/Prefabs/New Tank", menuName = "ScriptableObjects/Tank")]
public class TankScriptableObject : ScriptableObject
{
    public TankType tankType;
    public string TankName;
    public float Speed;
    public float Health;
}

[CreateAssetMenu(fileName = "Assets/Prefabs/TankScriptableObjectLists", menuName = "Tank Lists")]
public class TankScriptableObjectList : ScriptableObject
{
    public TankScriptableObject[] tanks;
}