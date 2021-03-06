﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour {


    //スクリプトで制御するGameObjectを用意
    private GameObject obj1;

    //オブジェクトが見えているかの判定をするフラグ
    private bool showflag;

    // Use this for initialization
    void Start () {

        //例：Testsqという名前のGameObjectをobj1に格納
        obj1 = GameObject.Find("Testsq");
        //フラグを初期化
        showflag = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //showflagがtureなら、表示オブジェクトを消す
            if (showflag) {
                Debug.Log("click");
                //ここでオブジェクトを消す
                obj1.SetActive(false);
                //フラグを管理
                showflag = false;
            }
            else if (showflag == false)
            {
                //オブジェクトを表示
                obj1.SetActive(true);
                //フラグを管理
                showflag = true;
            }
        }
		
	}
}
