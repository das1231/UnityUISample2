using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test004Dlg : MonoBehaviour
{
    [SerializeField] Slider m_sld = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    void Start()
    {
        m_sld.onValueChanged.AddListener(OnValue_Sld);
        m_btnOk.onClick.AddListener(OnClick_Ok);
        m_btnClear.onClick.AddListener(OnClick_Clear);
    }

    private void OnValue_Sld(float value)
    {
        m_txtResult.text = $"{value}";
    }

    private void OnClick_Ok()
    {
        m_txtResult.text = $"현재 진행된 값은 {m_sld.value} 입니다.";
    }

    private void OnClick_Clear()
    {
        m_sld.value = 0;
        m_txtResult.text = "";
    }


}
