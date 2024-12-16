using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class recipes 
{
    public string Name;
    public List<string> steps;
    public List<string> ingredients;
    public string difficulty;         
    public int score;                
}
