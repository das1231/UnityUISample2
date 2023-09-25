using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test001Dlg : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] Button m_BtnOk = null;
    [SerializeField] Button m_BtnClear = null;
    [Header("Text")]
    [SerializeField] Text m_TxtResult = null;
    [Header("InputField")]
    [SerializeField] InputField m_InpName = null;
    void Start()
    {
        m_BtnOk.onClick.AddListener(OnClicked_Ok);
        m_BtnClear.onClick.AddListener(OnClicked_Clear);
        m_InpName.onSubmit.AddListener(OnSubmit_Name);
        m_TxtResult.text = "출력";
    }
    private void OnSubmit_Name(string arg0)
    {
        m_TxtResult.text = $"<color=#2fe02f>{arg0}</color>";
    }
    private void OnClicked_Clear()
    {
        m_TxtResult.text = "";
    }
    private void OnClicked_Ok()
    {
        m_TxtResult.text = $"입력한 이름은 <color=#ff2e0f>{m_InpName.text}</color> 입니다.";
    }
}
