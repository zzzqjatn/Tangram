using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleLvPart : MonoBehaviour
{
    public PuzzleType puzzleType = PuzzleType.NONE;
    private Image puzzleImage = default;

    void Start()
    {
        puzzleImage = gameObject.
            FindChildObj("PuzzleLvImage").GetComponentMust<Image>();

        // 퍼즐 이미지 이름에 따라서 퍼즐의 타입이 정해진다.
        switch (puzzleImage.sprite.name)
        {
            case "Puzzle_BigTriangle1":
                puzzleType = PuzzleType.PUZZLE_BIG_TRIANGLE;
                break;
            case "Puzzle_BigTriangle2":
                puzzleType = PuzzleType.PUZZLE_BIG_TRIANGLE;
                break;
            default:
                puzzleType = PuzzleType.NONE;
                break;
        }   //switch()
    }

    void Update()
    {

    }
}
