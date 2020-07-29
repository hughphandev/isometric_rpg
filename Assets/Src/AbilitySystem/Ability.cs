using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public string name = "Ability Name";
    public string desc = "Ability Desciption";
    public float coolDown = 1;
    public float castTime;
    public Sprite icon;
    public AudioClip sound;

    public abstract string Type { get; }

}
