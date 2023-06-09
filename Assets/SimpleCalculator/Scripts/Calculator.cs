using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    #region Fields
    public TMPro.TextMeshProUGUI InputText;
    private float _result;
    private float _input;
    private float _input2;
    private string _operation;
    #endregion Fields

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickNumber(int val)
    {
        Debug.Log($" check val: {val}");
        InputText.text = $"{val}";
       if (_input ==0)
       {
        _input = val;
       }
       else
       {
        _input2 = val;
       }
    }

    public void ClickOperation(string val)
    {
        Debug.Log($" ClickOperation val: {val}");
        _operation = val;
    }
    public void ClickEqual(string val)
    {
        Debug.Log($" ClickEqual val: {val}");
        if(_input != 0 && _input2 !=0 && !string.IsNullOrEmpty(_operation) )
        {
            switch (_operation)
            {
                case "+":
                _result = _input + _input2;
                break;
                case "-":
                _result = _input - _input2;
                break;
                case "*":
                _result = _input * _input2;
                break;
                case "/":
                _result = _input / _input2;
                break;
            }
            InputText.SetText(_result.ToString());
            ClearInput();
        }
    }

    public void ClickPeriod(string val)
    {
        Debug.Log($" ClickPeriod val: {val}");
    }

    private void ClearInput()
    {
        _input = 0;
        _input2 = 0;
    }

    #endregion Methods

    #region Events
    #endregion Events
}
