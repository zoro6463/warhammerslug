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

        //>>여기부터 새로운 수정
        //점프
        if(Input.GetButtonDown("Jump")) {
            playerCtrl.ActionJump();
            return; // 점프 후 바로 공격 못하게 정지시킴

        }

        //공격
        if (Input.GetButtonDown("Fire1"))
        {
            playerCtrl.ActionAttack();
        }
	}
}
