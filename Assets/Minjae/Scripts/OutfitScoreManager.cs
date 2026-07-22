using UnityEngine;

public class OutfitScoreManager : MonoBehaviour
{

    private Outfits selectedShirt;
    private Outfits selectedPants;
    private Outfits selectedShoes;
    private Outfits selectedAcc;

    public void SelectOutfit(Outfits selectedOutfit)
    {
        switch (selectedOutfit.outfitType)
        {
            case Outfits.OutfitType.Shirt:
            selectedShirt = selectedOutfit;
            break;

            case Outfits.OutfitType.Pants:
            selectedPants = selectedOutfit;
            break;
            
            case Outfits.OutfitType.Shoes:
            selectedShoes = selectedOutfit;
            break;

            case Outfits.OutfitType.Acc:
            selectedAcc = selectedOutfit;
            break;
        }
        Debug.Log("Selected: " + selectedOutfit.outfitName);
    }

    private int GetOutfitScore(Outfits outfit)
    {
        switch (outfit.outfitRating)
        {
            case Outfits.OutfitRating.Love:
            return 30;

            case Outfits.OutfitRating.Neutral:
            return 20;

            case Outfits.OutfitRating.Hate:
            return 10;

            default:
            return 0;
        }
    }

    public int CalculateFinalScore()
    {
        if (selectedShirt == null || selectedPants == null || selectedShoes == null || selectedAcc == null)
        {
            Debug.LogWarning("Not all outfit pieces have been selected");
            return 0;
        }

        int finalScore = GetOutfitScore(selectedShirt)
        + GetOutfitScore(selectedPants)
        + GetOutfitScore(selectedShoes)
        + GetOutfitScore(selectedAcc);

        Debug.Log("Final Score: " + finalScore);

        return finalScore;
    }

    public void CheckResult()
    {
        int finalScore = CalculateFinalScore();

        if (finalScore <= 60)
        {
            Debug.Log("Fail");
        }
        else if (finalScore >= 120)
        {
            Debug.Log("Win");
        }
        else
        {
            Debug.Log("Meh");
        }
    }
}
