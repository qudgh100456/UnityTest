using UnityEngine;
using System.Collections;

public class DynmicAxis : MonoBehaviour
{
    public float m_fSpeed = 10.0F;
    public float m_fRotSpeed = 100.0F;

    void Update()
    {
        //OnGUI 에서 Update에서 옮기기
        float fVertical = Input.GetAxis("Vertical");
        float fHorizontal = Input.GetAxis("Horizontal");

        if (Mathf.Abs(fVertical) > 0 || Mathf.Abs(fHorizontal) > 0)
        {
            float fTranslation = fVertical * m_fSpeed;
            float fRotation = fHorizontal * m_fRotSpeed;
            fTranslation *= Time.deltaTime;
            fRotation *= Time.deltaTime;
            transform.Translate(0, 0, fTranslation);
            transform.Rotate(0, fRotation, 0);
        }
    }

    private void OnGUI()
    {
     
    }
    //물리를 이용하여 충돌체크(통과:X)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(name + ".OnCollisionEnter:" + collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(name + ".OnCollisionStay:" + collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(name + ".OnCollisionExit:" + collision.gameObject.name);
    }
    //물리를 이양하지않고 충돌체크(통과:O)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + ".OnTriggerEnter:" + other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(name + ".OnTriggerEnter:" + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(name + ".OnTriggerEnter:" + other.gameObject.name);
    }
}