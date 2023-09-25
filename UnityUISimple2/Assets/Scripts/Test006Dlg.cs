using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test006Dlg : MonoBehaviour
{
    [SerializeField] Scrollbar m_sb = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    void Start()
    {
        m_sb.onValueChanged.AddListener(OnValue_Sb);
        m_btnClear.onClick.AddListener(OnClick_Clear);
        m_btnOk.onClick.AddListener(OnClick_Ok);
    }

    private void OnClick_Ok()
    {
        m_txtResult.text = $"현재 진행된 값은 {m_sb.value:F2} 입니다";
    }

    private void OnClick_Clear()
    {
        m_sb.value = 0;
    }

    private void OnValue_Sb(float value)
    {
        m_txtResult.text = $"{value}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
