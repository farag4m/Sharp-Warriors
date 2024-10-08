using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HallFace
{
    Left,
    Right,
    Far,
    Close,
    Ceiling,
    Floor
}

public class HallwayComp : MonoBehaviour
{
    [SerializeField] private HallFace face;

    public HallFace Face { get { return face; } set { face = value; } }
}