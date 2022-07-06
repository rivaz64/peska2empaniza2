using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Fish", menuName = "fish")]
public class FishData : ScriptableObject
{
    public string name;
    public int points;
    public Sprite image;
    public float vel;
    public float border;
    public float sizeX;
    public float sizeY;
}
