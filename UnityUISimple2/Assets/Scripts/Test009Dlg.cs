using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test009Dlg : MonoBehaviour
{
    [SerializeField] Dropdown m_dd = null;
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Text m_txtResult = null;
    List<string> ddList = new List<string>() { "����","��ĥ��","����"}; 
    void Start()
    {
        m_txtResult.text = "";
        m_btnOk.onClick.AddListener(OnClick_Ok);
        m_btnClear.onClick.AddListener(OnClick_Clear);
        m_dd.onValueChanged.AddListener(OnValue_Dd);
        //Dropdown.OptionData data1 = new Dropdown.OptionData("��õ��");
        //m_dd.options.Add(data1);
        m_dd.AddOptions(ddList);
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
