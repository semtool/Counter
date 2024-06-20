using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update

    private Text textToEdit;

    private int total = 0;
    void Start()
    {
        textToEdit = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        total += 1;
        textToEdit.text = total.ToString();
        Debug.Log("Sprite Clicked");
    }

    //public void ChangeText()
    //{

    //    total += 1;
    //    textToEdit.text = total.ToString();

    //}
}
