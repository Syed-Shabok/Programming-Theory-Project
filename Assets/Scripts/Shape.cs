using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Shape : MonoBehaviour
{   
    [SerializeField]
    protected TextMeshProUGUI gameText;

private string m_objectColor;
    protected string objectColor  // ENCAPSULATION
    {
        get { return m_objectColor; } 
        set { m_objectColor = value; }
    }

    private string m_objectShape;
    protected string objectShape  // ENCAPSULATION
    {
        get { return m_objectShape; } 
        set { m_objectShape = value; }
    }

    protected virtual void GiveObjectDiscription()
    {
        gameText.text = "You clicked on a shape";
    }

    protected virtual void ChangeTextColor()
    {
        gameText.color = Color.white;
    }

    void OnMouseDown()
    {
        GiveObjectDiscription();  // ABSTRACTION
    }
    
}
