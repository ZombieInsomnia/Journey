using UnityEngine;

[CreateAssetMenu(fileName = "Outfits", menuName = "Outfit/Create New Outfit")]
public class Outfits : ScriptableObject
{
    public string outfitName; //name of the outfit
    public Sprite outfit; //assigns the image of the outfit for another code to be able to call and set
    public enum OutfitRating { Love, Like, Neutral, Dislike, Hate, Secret};
    public enum OutfitType { Shirt, Pants, Shoes, Acc}
    //character can have different dialgoue depending on the enum assigned, helps if we want to have multiple characters with different reactions
    public OutfitRating outfitRating;
    public OutfitType outfitType;

    
}
