using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour {

    public GameObject mCellPrefab;
    public Cell[,] mAllCells = new Cell[15, 15];
   // public GameObject mObstaclePrefab;
   // public GameObject obs;
   // public Image ground;
    public void Create()
    {
        if (!mCellPrefab.GetComponent<BoxCollider2D>())
        {
            BoxCollider2D cCell = mCellPrefab.AddComponent<BoxCollider2D>();
        }
        for (int y = 0; y < 15; y++)
        {
            for (int x = 0; x < 15; x++)
            {
                GameObject newCell = Instantiate(mCellPrefab, transform);
                RectTransform rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((x * 12) + 6, (y * 12) + 6);
                mAllCells[x, y] = newCell.GetComponent<Cell>();
                mAllCells[x, y].setup(new Vector2Int(x, y), this);
            }
        }
        //mAllCells[0, 0] = obs.GetComponent<Cell>();
        //mAllCells[0, 0].setup(new Vector2Int(0, 0), this);
        //for(int x = 0; x < 15; x++)
        //{
        //    for(int y = 0; y < 15; y++)
        //    {
        //        mAllCells[x, y].GetComponent<Image>().color = new Color32(230 , 220 , 187 , 255);
        //    }
        //}
    }

  
}
