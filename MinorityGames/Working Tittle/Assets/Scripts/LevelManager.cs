using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Image selectedArena;
    public Sprite[] lvl_collection;
    // Use this for initialization
    void Start()
    {

    }
    public void ChangeArena(int index)
    {
        selectedArena.sprite = lvl_collection[index];
    }
}
