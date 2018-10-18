using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour {


    public Image mOutImage;
    [HideInInspector]
    public Vector2 mAmbientPosition = Vector2Int.zero;
    [HideInInspector]
    public Ambient mAmbient = null;
    [HideInInspector]
    public RectTransform mRectTransform = null;
    [HideInInspector]
    public Levelish mLevel = null;
    [HideInInspector]
    public Vector2 mLevelPosition = Vector2.zero;

    public void setup(Vector2 newAmbientPosition, Ambient newAmbient)
    {
        mAmbientPosition = newAmbientPosition;
        mAmbient = newAmbient;
        mRectTransform = GetComponent<RectTransform>();
    }
    //public void LevelSetup(Vector2 newLevelPosition , Levelish newLevel)
    //{
    //    mLevelPosition = newLevelPosition;
    //    mLevel = newLevel;
    //    mRectTransform = GetComponent<RectTransform>();
    //}
}
