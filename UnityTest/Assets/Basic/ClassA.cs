using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct StructA
{
    int m_nData;
    public StructA(int data)
    {
        m_nData = data;
    }
    //void SetData(int data)
    //{
    //    m_nData = data;
    //}
    //다음과같이 세터겟터를 한꺼번에 만들고,
    public int Data 
    {
        //필요없는것이 있다면 만들지않거나 주석하면됨.
        get { return m_nData; }
        set { m_nData = value; }
    }
}

public class ClassA
{
    int m_nData;
    public ClassA(int data)
    {
        m_nData = data;
    }
  
    public int Data
    {
        get { return m_nData; }
        set { m_nData = value; }
    }
}
