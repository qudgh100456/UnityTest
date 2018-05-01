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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
