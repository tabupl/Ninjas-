using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour {

    [SerializeField] float tileSize = 0.64f;
    [SerializeField] GameObject[] tiles;
    [SerializeField] GameObject[] objects;


    private List<GameObject> tileList = new List<GameObject>();
    private List<GameObject> objectsList = new List<GameObject>();
	// Use this for initialization
	void Start () {
		for(int x = 0; x< 256; x++)
        {
            for(int y = 0; y<256; y++)
            {
                int randomObject = Random.Range(0, 100);
                if (randomObject > 97)
                    createObject(x, y);
                createTile(x, y);
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void createTile(int x, int y)
    {
        int whichTile = Random.Range(0, tiles.Length);
        GameObject newTile = Instantiate(tiles[whichTile]);
        newTile.transform.position = new Vector2(x * tileSize, y*tileSize);
        tileList.Add(newTile);

    }

    private void createObject(int x, int y)
    {
        int whichObject = Random.Range(0, objects.Length-1);
        GameObject newObject = Instantiate(objects[whichObject]);
        newObject.transform.position = new Vector2(x * tileSize, y * tileSize);
        objectsList.Add(newObject);
    }
}
