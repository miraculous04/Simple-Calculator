using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculatorScript : MonoBehaviour
{
    #region Fields
    public TextMeshProUGUI InputText;
    private float input2;
    private float input;
    private float result;
    private string operation;
    #endregion Fields

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ClickNumber(int val)
    {
        Debug.Log(message: $"val: {val}");
        InputText.text = $"{val}";
        if(input == 0)
        {
            input = val;
        }else
        {
            input2 = val;
        }
    }

    public void ClickOperator(string val)
    {
        Debug.Log(message: $"val: {val}");
        operation = val;
    }

    public void ClickEqual(string val)
    {
        Debug.Log(message: $"val: {val}");
        if(input != 0 && input2 != 0 && !string.IsNullOrEmpty(operation))
        {
            switch(operation)
            {
                case "+":
                    result = input + input2;
                    break;
                case "-":
                    result = input - input2;
                    break;
                case "*":
                    result = input * input2;
                    break;
                case "/":
                    result = input / input2;
                    break;
            }
            InputText.SetText(result.ToString());
            clearInput();
        }
    }

    public void ClickPeriod(string val)
    {
        Debug.Log(message: $"val: {val}");
    }

    private void clearInput()
    {
        input = 0;
        input2 = 0;
    }

    #endregion Methods

    #region Events
    #endregion Events
}

