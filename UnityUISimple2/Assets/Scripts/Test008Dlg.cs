using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test008Dlg : MonoBehaviour
{
    [SerializeField] Dropdown m_dd = null;
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_txtResult.text = "";
        m_btnOk.onClick.AddListener(OnClick_Ok);
        m_btnClear.onClick.AddListener(OnClick_Clear);
        m_dd.onValueChanged.AddListener(OnValue_Dd);
    }
    void OnClick_Ok()
    {
        m_txtResult.text = $"����� �̵��� ���ô� {m_dd.captionText.text} �Դϴ�";
    }
    void OnValue_Dd(int value)
    {
        m_txtResult.text = $"{value}: {m_dd.options[value].text}";
    }
    void OnClick_Clear()
    {
        m_txtResult.text = "";
    }
}
