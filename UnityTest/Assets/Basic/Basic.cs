using System.Collections;
using System.Collections.Generic;
using UnityEngine; //유니티의 라이브러리를 가져다 씀.

//유니티에서 스크립트를 작성할때 가장 기본적인 상속 클래스
public class Basic : MonoBehaviour
{
    StructA m_sStruct;
    ClassA m_cClass; //객체 //ClassA* m_pClass;
    // Use this for initialization
    void Start () {
        //모노비헤이비어로 부터 상속받은 멤버들. 
        //컴포넌트나 게임오브젝트 정보등을 가지고 있다.
        this.transform.position = new Vector3(0,0,0);
        //구조체는 정적할당됨.
        m_sStruct = new StructA(200);//생성자함수호출
        //m_sStruct.Data = 10; //셋터사용
        Debug.Log("StructData:"+m_sStruct.Data); //겟터사용
        m_cClass = new ClassA(100); //인스턴스 생성(동적할당)
        //m_cClass.Data = 20; 
        Debug.Log("ClassData:" + m_cClass.Data);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
