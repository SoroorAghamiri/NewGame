using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levelish : MonoBehaviour {

    public GameObject mObstaclePrefab;
    //public Obstacle[,] mAllObstacles = new Obstacle[9,9];
    //public Ambient newAmbient;

    //public void Create()
    //{

    //    int x = 3;
    //    int y = 1;
    //   for(int i = 0; i < 9; i++)
    //    {
    //        for(int j = 0; j < 9; j++)
    //        {
    //            GameObject obs1 = Instantiate(mObstaclePrefab, newAmbient.transform);
    //            RectTransform rtobs1 = obs1.GetComponent<RectTransform>();
    //            rtobs1.anchoredPosition = new Vector2((x * 12) + 6, (y * 12) + 6);
    //            mAllObstacles[i, j] = obs1.GetComponent<Obstacle>();
    //            mAllObstacles[i, j].setup(new Vector2(x, y), newAmbient);
    //        }
    //    }

    //}//end of create
    
    void Start()
    {
        if (!mObstaclePrefab.GetComponent<BoxCollider2D>())
        {
            BoxCollider2D cObstacle = mObstaclePrefab.AddComponent<BoxCollider2D>();
        }

        GameObject obs1 = Instantiate(mObstaclePrefab, new Vector3(508.1f, 884.9f, 0) , Quaternion.identity);
        RectTransform obs1RT = obs1.GetComponent<RectTransform>();
        obs1RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs2 = Instantiate(mObstaclePrefab, new Vector3(773.42f, 973.5f, 0), Quaternion.identity);
        RectTransform obs2RT = obs2.GetComponent<RectTransform>();
        obs2RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs3 = Instantiate(mObstaclePrefab, new Vector3(817.9f, 973.5f, 0), Quaternion.identity);
        RectTransform obs3RT = obs3.GetComponent<RectTransform>();
        obs3RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs4 = Instantiate(mObstaclePrefab, new Vector3(419.4f, 1194.8f, 0), Quaternion.identity);
        RectTransform obs4RT = obs4.GetComponent<RectTransform>();
        obs4RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs5 = Instantiate(mObstaclePrefab, new Vector3(463.6f, 1194.8f, 0), Quaternion.identity);
        RectTransform obs5RT = obs5.GetComponent<RectTransform>();
        obs5RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs6 = Instantiate(mObstaclePrefab, new Vector3(552.2f, 1239f, 0), Quaternion.identity);
        RectTransform obs6RT = obs6.GetComponent<RectTransform>();
        obs6RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs7 = Instantiate(mObstaclePrefab, new Vector3(773.42f, 1283.4f, 0), Quaternion.identity);
        RectTransform obs7RT = obs7.GetComponent<RectTransform>();
        obs7RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs8 = Instantiate(mObstaclePrefab, new Vector3(773.42f, 1327.7f, 0), Quaternion.identity);
        RectTransform obs8RT = obs8.GetComponent<RectTransform>();
        obs8RT.localScale = new Vector3(3.719391f, 3.719388f, 0);

        GameObject obs9 = Instantiate(mObstaclePrefab, new Vector3(419.4f, 1415.8f, 0), Quaternion.identity);
        RectTransform obs9RT = obs9.GetComponent<RectTransform>();
        obs9RT.localScale = new Vector3(3.719391f, 3.719388f, 0);
    }
  
}//end of class
