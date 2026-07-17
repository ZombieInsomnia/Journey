using UnityEngine;

[CreateAssetMenu(fileName = "Outfits", menuName = "Outfit/Create New Outfit")]
public class Outfits : ScriptableObject
{
    public string outfitName; //name of the outfit
    public Sprite outfit; //assigns the image of the outfit for another code to be able to call and set
    public int outfitRating; //character can have different dialgoue depending on the number assigned, helps if we want to have multiple characters with different reactions
}
