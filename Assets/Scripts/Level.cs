using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBlocks; //serialized for debugging purposes

    //cached reference
    SceneLoader sceneLoader;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    // Update is called once per frame
    void Update(){}

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--; //decrease number of blocks
        if(breakableBlocks <= 0) sceneLoader.loadNextScene(); //if there are no more blocks, load next scene
    }
}