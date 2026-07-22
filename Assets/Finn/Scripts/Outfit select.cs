using UnityEngine;
using UnityEngine.UI;


public class Outfitselect : MonoBehaviour
{
    public Outfits Outfits; //setting what outfit the button coresponds too 

    
    public GameObject outfitbox; //the image box the outfit is set too
    public Image outfitsprite;
    public GameObject dialoguebox;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Reference to the scoring system - MJ
    public OutfitScoreManager scoreManager;

    public void outfitSelect()
    {
        
        Debug.Log("you've picked " + Outfits.outfitName);
        
        outfitsprite.sprite = Outfits.outfit;
        // Sends the selected outfit to the score manager - MJ
        scoreManager.SelectOutfit(Outfits);
        outfitbox.SetActive(true);
        Reaction();
    }

    public void Reaction()
    {
        dialoguebox.SetActive(true);
       
    }
}
