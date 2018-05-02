using UnityEngine;
using System.Collections;

public class DynmicAxis : MonoBehaviour
{
    public float m_fSpeed = 10.0F;
    public float m_fRotSpeed = 100.0F;
    public Camera m_cCamera;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //마우스의 2D좌표를 이용하여 광선 생성(광선시작위치,광선방향)
            Ray ray = m_cCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo; //충돌이 성공했을때 충돌된 물체의 정보
            float fDistace = 100; //충돌체크용(광선길이)
            //광선의 길이 안에 물체가 있다면 hitInfo에 저장된다.
            if (Physics.Raycast(ray, out hitInfo, fDistace))
            {
                if (hitInfo.collider)
                {
                    switch (hitInfo.collider.gameObject.name)
                    {
                        case "book":
                            GameManager.GetInstence().Event(GameManager.eItemBox.BOOK);
                            break;
                        case "Toolkit":
                            break;
                        case "closet":
                            //문을 열도록만듦.
                            hitInfo.collider.gameObject.GetComponent<Closet>().Open();
                            break;
                    }
                    Debug.Log("Ray:" + hitInfo.collider.gameObject.name);
                }
            }
        }
    }

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
        switch(collision.gameObject.name)
        {
            case "bed":
                break;
            case "closet":
                break;
            case "desk":
                break;
        }

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