using UnityEngine;
using UnityEngine.UI;

public class Test007Dlg : MonoBehaviour
{
    [SerializeField] Scrollbar m_sb = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;

    float m_time = 0;
    bool m_start = false;
    void Start()
    {
        m_sb.value = 0;
        m_sb.onValueChanged.AddListener(OnValue_Sb);
        m_btnClear.onClick.AddListener(OnClick_Clear);
        m_btnOk.onClick.AddListener(OnClick_Ok);
    }

    private void OnClick_Ok()
    {
        //시작
        m_start = true;
    }

    private void OnClick_Clear()
    {
        //종료
        m_sb.value = 0;
        m_start = false;
    }

    private void OnValue_Sb(float value)
    {
        Color color = m_txtResult.color;
        Color c = new Color(color.r, color.g, color.b, value);
        m_txtResult.color = c;

        m_txtResult.text = $"{value:F2}";
    }

    void Update()
    {
        if (m_sb.value < 1)
        {
            if (m_start)
            {
                m_time += Time.deltaTime;
                if (m_time >= 0.5f)
                {
                    m_sb.value += 0.05f;
                    m_time = 0;
                }
            }
        }
        else
            m_sb.value = 1;
    }
}
