using UnityEngine;
using System.Collections;

public class PlayerMain : MonoBehaviour {


    //====캐시===================================
    PlayerController playerCtrl;


	//=====코드(monobehaviour 기본 기능 구현)-----
    
    void Awake()
    {
        playerCtrl = GetComponent<PlayerController>();
    }

	// 
	void Update () {
        // 조작 가능한가?
        if(!playerCtrl.activeSts) {
            return;
        }
        // 패드처리
        float joyMv = Input.GetAxis("Horizontal");
        playerCtrl.ActionMove(joyMv);

        //점프
        if(Input.GetButtonDown("Jump")) {
            playerCtrl.ActionJump();
        }
	}
}
