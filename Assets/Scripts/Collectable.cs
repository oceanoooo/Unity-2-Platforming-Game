using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Collectable : MonoBehaviour
{
    public string collectablename;
    public string description;
    public Gameobject player;

    public abstract void Use();
}
