using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ambient : MonoBehaviour
{
    public GameObject mObstaclePrefab;
    public Obstacle[,] mAllCells = new Obstacle[15, 15];
    //Ambient mAmbient;


    public void Create()
    {
        int y1 = 0;
        int y2 = 14;
        //for givin box collider 
        if (!mObstaclePrefab.GetComponent<BoxCollider2D>())
        {
            BoxCollider2D cObstacle = mObstaclePrefab.AddComponent<BoxCollider2D>();
        }
        
        for (int x = 0; x < 15; x++)
        {
            GameObject newObstacle = Instantiate(mObstaclePrefab, transform);
            RectTransform rectTransform = newObstacle.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2((x * 12) + 6, (y1 * 12) + 6);
            mAllCells[x, y1] = newObstacle.GetComponent<Obstacle>();
            mAllCells[x, y1].setup(new Vector2(x, y1), this);



            //mAllCells[x+14, 14] = newObstacle.GetComponent<Obstacle>();
            //mAllCells[x+14, 14].setup(new Vector2Int(x+14, 14), this);
        }
        for (int x = 0; x < 15; x++)
        {
            GameObject newObstacle = Instantiate(mObstaclePrefab, transform);
            RectTransform rectTransform = newObstacle.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2((x * 12) + 6, (y2 * 12) + 6);
            mAllCells[x, y2] = newObstacle.GetComponent<Obstacle>();
            mAllCells[x, y2].setup(new Vector2(x, y2), this);
        }

        int x1 = 0;
        for (int y = 0; y < 15; y++)
        {
            GameObject newObstacle = Instantiate(mObstaclePrefab, transform);
            RectTransform rectTransform = newObstacle.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2((x1 * 12) + 6, (y * 12) + 6);
            mAllCells[x1, y] = newObstacle.GetComponent<Obstacle>();
            mAllCells[x1, y].setup(new Vector2(x1, y), this);
        }

        int x2 = 14;
        for (int y = 0; y < 15; y++)
        {
            GameObject newObstacle = Instantiate(mObstaclePrefab, transform);
            RectTransform rectTransform = newObstacle.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2((x2 * 12) + 6, (y * 12) + 6);
            mAllCells[x2, y] = newObstacle.GetComponent<Obstacle>();
            mAllCells[x2, y].setup(new Vector2(x2, y), this);
        }

    }

}
