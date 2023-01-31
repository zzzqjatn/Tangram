using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleInitZone : MonoBehaviour
{
    public Canvas parentCanvas = default;
    void Start()
    {
        GFunc.Assert(parentCanvas != null || parentCanvas != default);
    }

    void Update()
    {

    }
}
