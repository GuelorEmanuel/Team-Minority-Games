using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Image selectedArena;
    public Sprite[] lvl_collection;
    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("Fight"))
        {
            LoadArena();
        }
    }
    public void ChangeArena(int index)
    {
        Sprite sp = lvl_collection[index];
        selectedArena.sprite = sp;
        SaveArena(sp);
    }
    public void SaveArena(Sprite sp)
    {
        PlayerPrefs.SetString("SelectedArena", sp.name);
    }
    public void LoadArena()
    {
        selectedArena.sprite = Resources.Load<Sprite>(PlayerPrefs.GetString("SelectedArena"));
    }
}
