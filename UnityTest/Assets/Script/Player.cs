using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    List<ItemManager.eItem> m_listIventory;

    void SetIventory(ItemManager.eItem item)
    {
        m_listIventory.Add(item);
    }

    void DeleteIvetory(ItemManager.eItem item)
    {
        m_listIventory.Remove(item);
    }

    private void OnGUI()
    {
        for (int i = 0; i < m_listIventory.Count; i++)
        {
            GUI.Box(new Rect(0, 20 * i, 100, 20), ""+m_listIventory[i]);
            //Debug.Log(m_listItems[i].Name);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
