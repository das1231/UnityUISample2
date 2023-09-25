using UnityEngine;
using UnityEngine.UI;

public class Test002Dlg : MonoBehaviour
{
    [Header("Toggle")]
    [SerializeField] Toggle m_togApl = null;
    [SerializeField] Toggle m_togPear = null;
    [SerializeField] Toggle m_togOran = null;
    [Header("Button")]
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [Header("Text")]
    [SerializeField] Text m_txtResult = null;
    void Start()
    {
        m_togApl.onValueChanged.AddListener(IsOn_Apl);
        m_togPear.onValueChanged.AddListener(IsOn_Pear);
        m_togOran.onValueChanged.AddListener(IsOn_Oran);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_btnOk.onClick.AddListener(OnClicked_Ok);
    }

    private void OnClicked_Ok()
    {
        if (!m_togApl.isOn && !m_togOran.isOn && !m_togPear.isOn)
        {
            m_txtResult.text = "������ ������ �����ϴ�.";
        }
        else
        {
            m_txtResult.text = "����� ������ ������";
            if (m_togApl.isOn)
            {
                m_txtResult.text += "��� ";
            }
            if (m_togOran.isOn)
            {
                m_txtResult.text += "������ ";
            }
            if (m_togPear.isOn)
            {
                m_txtResult.text += "��";
            }
            m_txtResult.text += "�Դϴ�.";
        }
    }

    private void OnClicked_Clear()
    {
        m_txtResult.text = "";
    }

    private void IsOn_Oran(bool arg0)
    {
        if (arg0)
        {
            m_txtResult.text = "������";
        }
    }
    private void IsOn_Pear(bool arg0)
    {
        if (arg0)
        {
            m_txtResult.text = "��";
        }
    }

    private void IsOn_Apl(bool arg0)
    {
        if (arg0)
        {
            m_txtResult.text = "���";
        }
    }
}
