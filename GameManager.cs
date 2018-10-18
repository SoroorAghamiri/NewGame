using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Board mBoard;
    public Ambient mAmbient;
    //public Levelish mLevel;

    //public PieceManager mPieceManager;
    void Start()
    {
        mBoard.Create();
        mAmbient.Create();
       // mLevel.Create();
        //mPieceManager.setup(mBoard);
    }
}
