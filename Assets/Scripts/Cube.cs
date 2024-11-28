using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape  // INHERITANCE
{       
    void Start()
    {
        objectColor = "blue";
        objectShape = "cube";
    }

    protected override void ChangeTextColor()  // POLYMORPHISM
    {
        gameText.color = Color.blue;
    }

    protected override void GiveObjectDiscription()  // POLYMORPHISM
    {
        gameText.text = $"You clicked on a {objectColor} {objectShape}.";
        ChangeTextColor();  // ABSTRACTION
    }

}
