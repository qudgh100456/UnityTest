using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Player m_cPlayer;
    public List<ItemBox> m_listItemBoxes;
    public ItemManager m_cItemManager;
    public enum eItemBox { DESK, BED, CLOSET, BOOK, TOOLKIT, DOOR }\

    static GameManager m_cInstace;

    static public  GameManager GetInstence()
    {
        return m_cInstace;
    }

	// Use this for initialization
	void Start () {
        m_cInstace = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Event(eItemBox item)
    {
        switch (item)
        {
            case eItemBox.DESK:
                m_listItemBoxes[(int)item].CheckEvent(m_cPlayer);
                break;
            case eItemBox.BED:
                m_listItemBoxes[(int)item].CheckEvent(m_cPlayer);
                break;
            case eItemBox.CLOSET:
                m_listItemBoxes[(int)item].CheckEvent(m_cPlayer);
                break;
            case eItemBox.BOOK:
                m_listItemBoxes[(int)item].CheckEvent(m_cPlayer);
                break;
            case eItemBox.TOOLKIT:
                m_listItemBoxes[(int)item].CheckEvent(m_cPlayer);
                break;
            case eItemBox.DOOR:
                m_listItemBoxes[(int)item].CheckEvent(m_cPlayer);
                break;
        }
    }
}
