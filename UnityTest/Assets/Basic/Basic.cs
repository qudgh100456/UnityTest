using System.Collections;
using System.Collections.Generic;
using UnityEngine; //유니티의 라이브러리를 가져다 씀.

//유니티에서 스크립트를 작성할때 가장 기본적인 상속 클래스
public class Basic : MonoBehaviour
{
    StructA m_sStruct;
    ClassA m_cClass; //객체 //ClassA* m_pClass;
    List<ClassA> m_listClassA; //std::vector(동적배열)와 같다.
    LinkedList<ClassA> m_linkedlistClassA; // std::list와 같다.
    Dictionary<string,ClassA> m_dicClassA; //std::map와 같다.

    // Use this for initialization
    void Start () {
        //모노비헤이비어로 부터 상속받은 멤버들. 
        //컴포넌트나 게임오브젝트 정보등을 가지고 있다.
        this.transform.position = new Vector3(0,0,0);
        //구조체는 정적할당됨.
        m_sStruct = new StructA(200);//생성자함수호출
        //m_sStruct.Data = 10; //셋터사용
        SetDataStruct(m_sStruct, 20);
        Debug.Log("StructData:"+m_sStruct.Data); //겟터사용
        m_cClass = new ClassA(100); //인스턴스 생성(동적할당)
        //생성된 인스턴스는 가비지컬렉션에의해 관리되므로 해제할필요없다.
        //m_cClass.Data = 20; 
        SetDataClass(m_cClass, 10);
        Debug.Log("ClassData:" + m_cClass.Data);
        //1.더하기를 하여 문자열를 생성
        string addPlus = "A" + "d" + "d"; 
        //2.포맷함수를 이용하여 문자열생성: 문자열을 합칠때는 이러한형식을 쓰는것이 오버헤드가 적다.
        string addFormat = string.Format("{0}{1}{2}", "A", "d", "d"); 
        Debug.Log(string.Format("{0}/{1}",addPlus,addFormat));
    }
	
    void SetDataStruct(StructA s, int data)
    {
        s.Data = data;
    }

    void SetDataClass(ClassA s, int data)
    {
        s.Data = data;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
