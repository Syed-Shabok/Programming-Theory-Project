using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape  // INHERITANCE
{
    void Start()
    {
        objectColor = "green";
        objectShape = "capsule";
    }

    protected override void ChangeTextColor()  // POLYMORPHISM
    {
        gameText.color = Color.green;
    }
    
    protected override void GiveObjectDiscription()  // POLYMORPHISM
    {
        gameText.text = $"You clicked on a {objectColor} {objectShape}.";
        ChangeTextColor();  // ABSTRACTION
    }
}
