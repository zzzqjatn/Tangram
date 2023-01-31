using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,
    IDragHandler
{
    private bool isClicked = false;
    private RectTransform objRect = default;
    private PuzzleInitZone puzzleInitZone = default;

    void Start()
    {
        isClicked = false;
        objRect = gameObject.GetRect();
        puzzleInitZone = transform.parent.gameObject.GetComponentMust<PuzzleInitZone>();
    }

    void Update()
    {

    }

    //! 마우스 버튼을 눌렀을 때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;

        //DEBUG : 
        //GFunc.Log($"{gameObject.name}을 선택했다.");
    }   //OnPointerDown()

    //! 마우스 버튼에서 손을 땠을 때 동작하는 함수
    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;

        //DEBUG : 
        //GFunc.Log($"{gameObject.name}을 선택 해제했다.");
    }   //OnPointerUp()

    //! 마우스를 드래그 중 일때 동작하는 함수
    public void OnDrag(PointerEventData eventData)
    {
        if (isClicked == true)
        {
            //gameObject.SetLocalPos(eventData.position.x, eventData.position.y, 0f);
            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanvas.scaleFactor);

            //GFunc.Log($"마우스의 포지션을 확인 : ({eventData.position.x} , {eventData.position.y})");
        }   // if: 현재 오브젝트를 선택한 경우
    }   //OnDrag()
}