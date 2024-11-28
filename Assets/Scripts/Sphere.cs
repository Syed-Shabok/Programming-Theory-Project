using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape  // INHERITANCE
{   
    void Start()
    {
        objectColor = "red";
        objectShape = "sphere";
    }

    protected override void ChangeTextColor()  // POLYMORPHISM
    {
        gameText.color = Color.red;
    }
    
    protected override void GiveObjectDiscription()  // POLYMORPHISM
    {
        gameText.text = $"You clicked on a {objectColor} {objectShape}.";
        ChangeTextColor();  // ABSTRACTION
    }
}
