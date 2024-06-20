using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTex : MonoBehaviour
{
    public  Text _textButton;
    private int total = 0;
    // Start is called before the first frame update
    void Start()
    {
        _textButton.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTxt()
    {
        total += 1;
        _textButton.text = total.ToString();
    }

}
