using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    string strName;
    string strCommnet;
    string strImage;
    public Item(string name, string comment, string img)
    {
        Set(name, comment, img);
    }
    public void Set(string name, string comment, string img)
    {
        strName = name;
        strCommnet = comment;
        strImage = img;
    }
}

public class ItemManager : MonoBehaviour {
    public enum eItem { KEY_PIACE01, KEY_PIACE02, KEY_PIACE03, KEY_PIACE04, KEY }
    List<Item> m_listItems = new List<Item>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init()
    {
        m_listItems.Add(new Item("열쇠조각1", "다른 열쇠조각이 필요할거같다.", "key1"));
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

   
}
