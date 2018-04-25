using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {
    public Text m_cText;
    Button m_cButton;
    public GameObejct m_cGameObj;
	// Use this for initialization
	void Start () {
        //오브젝트로 부터 필요한 컴포넌트를 받아오려면 GetCompent를 이용한다.
        m_cButton = this.gameObject.GetComponent<Button>();
        m_cButton = m_cGameObj.GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickEvnet()
    {
        m_cText.text = "test";
        m_cButton.colors = ColorBlock.defaultColorBlock;
    }
}
