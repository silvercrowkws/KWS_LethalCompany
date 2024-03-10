using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Store : MonoBehaviour
{
    /*/// <summary>
    /// 인풋 액션
    /// </summary>
    HardwareInputActions inputActions;

    private void Awake()
    {
        inputActions = new HardwareInputActions();      // 인풋 액션 생성
    }

    private void OnEnable()
    {
        inputActions.Hardware.Enable();
        inputActions.Hardware.Interactions.performed += OnInteractionStart; // Hardware액션 맵의 Interactions액션에 OnInteractionStart 함수를 연결(눌렀을 때만)
        //inputActions.Hardware.Interactions.canceled += OnInteractionEnd;    // Hardware액션 맵의 Interactions액션에 OnInteractionEnd 함수를 연결(땠을 때만)
    }

    private void OnDisable()
    {
        //inputActions.Hardware.Interactions.canceled -= OnInteractionEnd;    // 연결 해제
        inputActions.Hardware.Interactions.performed -= OnInteractionStart; // 연결 해제
        inputActions.Hardware.Disable();
    }


    public void OnInteractionStart(InputAction.CallbackContext context)
    {
        if (context.action.triggered)
        {
            Debug.Log($"F 키가 눌림");
        }
    }

    private void OnInteractionEnd(InputAction.CallbackContext _)
    {
        throw new NotImplementedException();
    }*/

    // private Player player;


    private Hardware1 hardware1;

    private void Start()
    {
        //Transform child = transform.GetChild(0);                // Store의 0번째 자식
        //Collider collider = child.GetComponent<Collider>();     // 0번째 자식의 콜라이더
        Collider collider = GetComponent<Collider>();

        hardware1 = FindObjectOfType<Hardware1>();

        // Hardware1 스크립트를 찾지 못했을 경우 오류 메시지 출력
        if (hardware1 == null)
        {
            Debug.LogError("Hardware1 스크립트를 찾을 수 없습니다!");
            return;
        }
    }

    private void OnEnable()
    {
        /*player = GetComponent<Player>(); // 더 나은 방법을 사용하도록 수정 가능

        if (player != null)
        {
            // F 액션에 대한 콜백 설정
            player.FAction.performed += OnFKeyPressed;
        }*/
    }

    private void OnFKeyPressed(InputAction.CallbackContext context)
    {
        if (context.action.triggered)
        {
            Debug.Log("B: F 키가 눌렸습니다!");
            // 여기에 F 키가 눌렸을 때 이 스크립트에서 수행할 동작을 추가
        }
    }

    private void OnDisable()
    {
        /*if (player != null)
        {
            // 콜백 연결 해제
            player.FAction.performed -= OnFKeyPressed;
        }*/
    }
        
    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 상대방 오브젝트가 있는지 확인
        if (collision.gameObject != null)
        {
            // 충돌한 상대방 오브젝트가 Hardware인지 확인
            // 나중에는 Hardware의 태그를 폐철물 종류마다 늘려서?
            if (collision.gameObject.CompareTag("Hardware"))
            {
                Debug.Log("Hardware를 발견했습니다!");

                // Hardware1 스크립트에서 가격을 가져와서 출력
                float price = hardware1.hardwarePrice;
                Debug.Log("무작위 가격: " + price);
            }
            else
            {
                Debug.Log("Hardware가 아닌 오브젝트를 발견했습니다!");
            }
        }
    }

}
