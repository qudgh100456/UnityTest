using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : ItemBox {
    bool m_bOpen;
    public OpenDoor m_cOpenDoor;

    public void Open()
    {
        m_cOpenDoor.Open();
    }

    public override bool CheckEvent(Player player)
    {
        return false;
    }

	// Use this for initialization
	void Start () {
        Open();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
