using UnityEngine;

[CreateAssetMenu(fileName = "New disease", menuName = "Assets/Disease")]
public class Illness : ScriptableObject
{
    public string illnessName;
    public int id;
    public float minTemperature;
    public float maxTemperature;
    public bool headAche;
    public bool throatAche;
    public bool lungAche;
    public bool pressure;
}
