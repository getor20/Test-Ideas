using UnityEngine;

[CreateAssetMenu(fileName = "FoodStatBlock", menuName = "StatBlock/Food Stat Block", order = -1000)]
public class FoodData : ScriptableObject
{
    public int ID;
    public string Name;
    public Sprite Icon;
    public string Description;
    public float Edibility;
    //public GameObject PrefabObject;
}
