using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject pantsMenu;
    public GameObject shirtMenu;
    public GameObject shoesMenu;
    public GameObject accMenu;


    public GameObject previousMenu;
    public GameObject nextMenu;
    public GameObject doneButton;

    public GameObject mainMenuButton;
    public GameObject tryAgainButton;

    public GameObject pantOutfitbox;
    public GameObject shirtOutfitbox;
    public GameObject shoesOutfitbox;
    public GameObject accOutfitbox;

    public GameObject dialogueBox;

    public Transform player;
    public GameObject playerSprite;
    public GameObject Confetti;

    // Reference to the scoringg system - MJ
    public OutfitScoreManager scoreManager;

    bool isDone = false;
    public int menuNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pantOutfitbox.SetActive(false);
        shirtOutfitbox.SetActive(false);
        shoesOutfitbox.SetActive(false);
        accOutfitbox.SetActive(false);
        doneButton.SetActive(false);
        mainMenuButton.SetActive(false);    
        tryAgainButton.SetActive(false);
        Confetti.SetActive(false);
        dialogueBox.SetActive(false);
        UpdateVisuals();
        
    }
    public void NextMenu()
    {
        if (menuNumber < 3)
        {
            menuNumber += 1;
            UpdateVisuals();
        }
    }
    public void PreviousMenu()
    {
        if (menuNumber >= 0) 
        {
            menuNumber -= 1;
            UpdateVisuals();
        }
    }

    public void DoneButton()
    {
        Debug.Log("yippee");
        //Calculates and checks the final outfit result - MJ
        scoreManager.CheckResult();
        isDone = true;
        UpdateVisuals();
    }

    void UpdateVisuals()
    {
        if (isDone == false)
        {
            if (menuNumber == 0)
            {
                shirtMenu.SetActive(true);
                pantsMenu.SetActive(false);
                shoesMenu.SetActive(false);
                accMenu.SetActive(false);
                previousMenu.SetActive(false);

            }

            if (menuNumber == 1)
            {
                shirtMenu.SetActive(false);
                pantsMenu.SetActive(true);
                shoesMenu.SetActive(false);
                previousMenu.SetActive(true);
                accMenu.SetActive(false);
            }

            if (menuNumber == 2)
            {
                shirtMenu.SetActive(false);
                pantsMenu.SetActive(false);
                shoesMenu.SetActive(true);
                accMenu.SetActive(false);
                nextMenu.SetActive(true);
                doneButton.SetActive(false);


            }

            if (menuNumber == 3)
            {
                shirtMenu.SetActive(false);
                pantsMenu.SetActive(false);
                shoesMenu.SetActive(false);
                accMenu.SetActive(true);
                doneButton.SetActive(true);
                nextMenu.SetActive(false);
            }
        }

        if (isDone == true)
        {
            shirtMenu.SetActive(false);
            pantsMenu.SetActive(false);
            shoesMenu.SetActive(false);
            accMenu.SetActive(false);
            doneButton.SetActive(false);
            nextMenu.SetActive(false);
            previousMenu.SetActive(false);
            MovePlayer();
            
        }
      
    }
    public void MovePlayer()
    {
        playerSprite.transform.SetParent(player);
        playerSprite.transform.localPosition = Vector3.zero;
        mainMenuButton.SetActive(true);
        tryAgainButton.SetActive(true);
        Confetti.SetActive(true);
        dialogueBox.SetActive(false);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
