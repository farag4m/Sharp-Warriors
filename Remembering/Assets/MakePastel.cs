using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[ExecuteInEditMode]
public class MakePastel : MonoBehaviour
{
    //Actually Private Vars
    private HallwayComp[] faces;
    public HallwayComp[] Faces { get { return faces; } internal set { faces = value; } }


    //Stuff that you can actually see in editor / their public gets & sets


    [Header("Parameters")]
    [SerializeField, Range(3, 100)] private float length;
    [SerializeField, Range(3, 100)] private float width;
    [SerializeField, Range(3, 100)] private float height;
    [Space]
    [SerializeField, Range(3, 100)] private float maxOffset;

    public float Length { get { return length; } set { length = value; } }
    public float Width { get { return width; } set { width = value; } }
    public float Height { get { return height; } set { height = value; } }
    public float MaxOffset { get { return maxOffset; } set { maxOffset = value; } }

    [Header("Faces")]
    [SerializeField] private HallwayComp left;
    [SerializeField] private HallwayComp right;
    [SerializeField] private HallwayComp close;
    [SerializeField] private HallwayComp far;
    [SerializeField] private HallwayComp ceiling;
    [SerializeField] private HallwayComp floor;

    public HallwayComp Left { get { return left; } internal set { left = value; } }
    public HallwayComp Right { get { return right; } internal set { right = value; } }
    public HallwayComp Close { get { return close; } internal set { close = value; } }
    public HallwayComp Far { get { return far; } internal set { far = value; } }
    public HallwayComp Ceiling { get { return ceiling; } internal set { ceiling = value; } }
    public HallwayComp Floor { get { return floor; } internal set { floor = value; } }

    void Start()
    {
        Faces = new HallwayComp[] { left, right, close, far, ceiling, floor };
    }

    void Update()
    {
        SetFaces();
    }

    public void SetFaces()
    {
        for (int i = Faces.Length - 1; i >= 0; i--)
        {
            HallwayComp obj = Faces[i];
            int pos;

            if (obj != null)
            {
                switch (obj.Face)
                {
                    case HallFace.Left:
                    case HallFace.Right:
                        //Scale
                        obj.gameObject.transform.localScale = new Vector3(Height, 1, Length) / 10;

                        //Position
                        pos = (obj.Face == HallFace.Left) ? -1 : 1;
                        obj.gameObject.transform.position = new Vector3(Width * pos, Height, Length) / 2;

                        break;

                    case HallFace.Close:
                    case HallFace.Far:
                        //Scale
                        obj.gameObject.transform.localScale = new Vector3(Width, 1, Height) / 10;

                        //Position
                        pos = (obj.Face == HallFace.Close) ? 0 : 2;
                        obj.gameObject.transform.position = new Vector3(0, Height, Length * pos) / 2;

                        break;

                    case HallFace.Ceiling:
                    case HallFace.Floor:
                        //Scale
                        obj.gameObject.transform.localScale = new Vector3(Width, 1, Length) / 10;

                        //Position
                        pos = (obj.Face == HallFace.Ceiling) ? 2 : 0;
                        obj.gameObject.transform.position = new Vector3(0, Height * pos, Length) / 2;

                        break;
                }
            }
        }
    }
}