using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    string strName;
    string strComment;
    string strImage;

    public string Name{ get { return strName; } }
    public string Comment { get { return strComment; } }
    public string Image { get { return strImage; } }

    public Item(string name, string comment, string img)
    {
        Set(name, comment, img);
    }
    public void Set(string name, string comment, string img)
    {
        strName = name;
        strComment = comment;
        strImage = img;
    }
}

public class ItemManager : MonoBehaviour {
    public enum eItem { KEY_PIACE01, KEY_PIACE02, KEY_PIACE03, KEY_PIACE04, KEY }
    List<Item> m_listItems = new List<Item>();
	// Use this for initialization
	void Start () {
        Init();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init()
    {
        m_listItems.Add(new Item("열쇠조각1", "다른 열쇠조각이 필요할거같다.", "key1"));
        m_listItems.Add(new Item("열쇠조각2", "다른 열쇠조각이 필요할거같다.", "key2"));
        m_listItems.Add(new Item("열쇠조각3", "다른 열쇠조각이 필요할거같다.", "key3"));
        m_listItems.Add(new Item("열쇠조각4", "다른 열쇠조각이 필요할거같다.", "key4"));
        m_listItems.Add(new Item("열쇠", "문을 열수있을거같다", "key"));
    }

    public void LoadItemInfo()
    {
        //Resources/Data/item.csv를 읽어서,
        //아이템을 자동으로 설정하도록만드세요!
    }

    public Item GetItem(eItem item)
    {
        return m_listItems[(int)item];
    }

    private void OnGUI() //간단한 디버깅용도로 레거시GUI사용하기
    {
        for(int i = 0; i<m_listItems.Count; i++)
        {
            GUI.Box(new Rect(Screen.width - 100,  20 * i, 100, 20), m_listItems[i].Name);
            //Debug.Log(m_listItems[i].Name);
        }
    }
}
