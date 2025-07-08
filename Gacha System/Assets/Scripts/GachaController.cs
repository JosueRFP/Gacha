using UnityEngine;

public enum Rarity 
{ 
    None, Star3, Star4, Star5, Ultra
}


public class GachaController : MonoBehaviour
{
    [SerializeField] GameObject[] characters;
    [SerializeField] float ghostPersentage;

    bool getNewCharacter = false;
    Rarity rarity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characters = new GameObject[characters.Length];

        for (int i = 0; i < characters.Length; i++) 
        {
            ghostPersentage += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
