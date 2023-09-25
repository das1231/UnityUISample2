using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test005Dlg : MonoBehaviour
{
    [Header("Slider")]
    [SerializeField] Slider m_sldR = null;
    [SerializeField] Slider m_sldG = null;
    [SerializeField] Slider m_sldB = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Text")]
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Text m_txtR = null;
    [SerializeField] Text m_txtG = null;
    [SerializeField] Text m_txtB = null;
    void Start()
    {
        m_btnOk.onClick.AddListener(OnClick_Ok);
        m_btnClear.onClick.AddListener(OnClick_Clear);
        m_sldR.onValueChanged.AddListener(OnValue_R);
        m_sldG.onValueChanged.AddListener(OnValue_G);
        m_sldB.onValueChanged.AddListener(OnValue_B);
    }

    private void OnValue_B(float value)
    {
        m_txtB.text = $"<color=#0000FF>{value}</color>";
    }
    private void OnValue_G(float value)
    {
        m_txtG.text = $"<color=#00FF00>{value}</color>";
    }
    private void OnValue_R(float value)
    {
        m_txtR.text = $"<color=#FF0000>{value}</color>";
    }

    private void OnClick_Clear()
    {
        m_txtResult.text = "";
        m_sldR.value = 0;
        m_sldG.value = 0;
        m_sldB.value = 0;
    }
    private void OnClick_Ok()
    {
        m_txtResult.text = "";
        m_txtResult.text = "현재 색상 값 입니다.";
    }
    private void Update()
    {
        m_txtResult.color = new Color(m_sldR.value / 255, m_sldG.value / 255, m_sldB.value / 255);
    }
}
