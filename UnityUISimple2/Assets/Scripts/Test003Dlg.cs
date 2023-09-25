using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test003Dlg : MonoBehaviour
{
    [Header("Toggle")]
    [SerializeField] Toggle m_togApl = null;
    [SerializeField] Toggle m_togOrng = null;
    [SerializeField] Toggle m_togPear = null;
    [Header("Btn")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Text")]
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_txtResult.text = "";
        m_togApl.onValueChanged.AddListener(OnValue_Apl);
        m_togPear.onValueChanged.AddListener(OnValue_Pear);
        m_togOrng.onValueChanged.AddListener(OnValue_Orng);
    }

    private void OnClicked_Clear()
    {
        m_togApl.isOn = true;
        m_txtResult.text = "";
    }

    private void OnValue_Orng(bool arg0)
    {
        m_txtResult.text = "오렌지";
    }

    private void OnValue_Pear(bool arg0)
    {
        m_txtResult.text = "배";
    }

    private void OnValue_Apl(bool arg0)
    {
        m_txtResult.text = "사과";
    }

    private void OnClicked_Ok()
    {
        m_txtResult.text = "당신이 선택한 과일은 ";
        if (m_togApl.isOn)
        {
            m_txtResult.text += "사과 ";
        }
        else if (m_togPear.isOn)
        {
            m_txtResult.text += "배 ";
        }
        else
        {
            m_txtResult.text += "오렌지 ";
        }
        m_txtResult.text += "입니다.";
    }
}
