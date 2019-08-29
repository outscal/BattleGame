using UnityEngine;

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Bullet", menuName = "ScriptableObjects/Bullets")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletType bulletType;
    public float Speed;
    public float Damage;
}

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/BulletScriptableObjectList", menuName = "ScriptableObjects/Bullet Lists")]
public class BulletScriptableObjectList : ScriptableObject
{
    public BulletScriptableObject[] bullets;
}
