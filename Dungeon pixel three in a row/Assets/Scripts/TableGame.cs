using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableGame : MonoBehaviour {

    int width = 5;
    int height = 8;

    public GameObject BlockPrefab;
    private GameObject[,] arrayBlock;

	// Use this for initialization
	void Start () {
        arrayBlock = new GameObject[width, height];
        SetDesk();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetDesk()
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                GameObject bl = Instantiate(BlockPrefab, new Vector2(i - 2, j - 4), Quaternion.identity);
                bl.transform.parent = transform;
                bl.name = (height * i + j).ToString();
                arrayBlock[i, j] = bl;
            }
        }
    }
}
