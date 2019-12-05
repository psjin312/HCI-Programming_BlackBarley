﻿/*
 *  프로그램명 : 네비게이션 구현을 위한 라인 구현
 *  작성자 : 2016039076 김종우 (최병도, 김종우, 박성진, 문재식, 김서빈)
 *  작성일 : 2019.12.02
 *  프로그램 설명 : 네비게이션 길 안내 프로그램을 구현하기 위해 도로위에 라인 구현
 */
using UnityEngine;

public class Line5 : MonoBehaviour
{
    LineRenderer lr;    //LineRenderer 생성
    Vector3 line5Pos, line6Pos;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.startWidth = 3.0f;   //시작 너비
        lr.endWidth = 3.0f;     //끝 너비

        line5Pos = gameObject.GetComponent<Transform>().position;
    }

    void Update()   //line6을 찾아 전 라인과 연결
    {
        lr.SetPosition(0, line5Pos);
        lr.SetPosition(1, GameObject.Find("line6").GetComponent<Transform>().position);
    }
}
