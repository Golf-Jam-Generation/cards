using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private AudioManager sfx;
    // Position on the grid
    [SerializeField]
    Transform[] cardPos = new Transform[6];
    // Cards to spawn (Prefabs)
    [SerializeField]
    GameObject[] cards;

    // Cards with attack to show
    GameObject[] cardsOnTable = new GameObject[6];
    [SerializeField] UIManage uiManager;

    #region card selection
    GameObject cardSelectedByPlayer;
    GameObject cardSelectedByPc;
    #endregion

    #region bool turns
    bool playerTurn;
    bool pcTurn;
    //bool onGame;
    #endregion

    
    int turn;
    int playerScore;
    int pcScore;

    void Start(){
        setTable();
        Time.timeScale = 1;
        sfx = FindObjectOfType<AudioManager>();
    }

    void Update(){
        if (turn<3){
            Turn();
        }
        else
        {
            Result();
        }
    }

    // Sets the table at the beggining of every round
    void setTable(){
        // instantiate the cards in the cardsOnTable array
        for (int i = 0; i < cardsOnTable.Length; i++)
        {   Card cardToSetAttack;
            int numberOfCard = Random.Range(0, cards.Length);
            cardsOnTable[i] = Instantiate(cards[numberOfCard], cardPos[i].position, Quaternion.identity);
            // set the attack for each card
            cardToSetAttack = cardsOnTable[i].GetComponent<Card>();
            cardToSetAttack.AssignAttack(numberOfCard+1);
        }
        
        // Turns and game
        //onGame=true;
        playerTurn = true;
        pcTurn = false;

        // number of turn 
        turn =0;

        //Scores
        playerScore = 0;
        pcScore = 0;
    }

    // Lets the player select a card
    GameObject SelectCard(){
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10.0f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            sfx.PlaySFX(sfx.click);

            if (Physics.Raycast(ray, out hit, 100)){
                Card cardSelected;
                cardSelected = hit.transform.gameObject.GetComponent<Card>();
                if (cardSelected!=null){
                    StartCoroutine(cardSelected.RotateCard());
                    return hit.transform.gameObject;
                }
                
            }
        }
        return null;
    }

    #region Turn Logic
    // Organizes all the functions that happend during one turn
    void Turn(){
        if (playerTurn){
            PlayerTurn();
        }
        if (pcTurn){
            StartCoroutine(PcTurn());
        }

        if (!playerTurn&&!pcTurn){
            Comparation();
        }
    }
    // Once the player selects a card, saves it and enables the pc to play
    void PlayerTurn(){
        cardSelectedByPlayer =  SelectCard();
        if (cardSelectedByPlayer!=null){
            playerTurn=false;
            pcTurn = true;
        }
    }
    // finds tha active cards in the table, saves them and discard the card selected by the player
    // then, randomly selects a card, flips it and finish its turn
    IEnumerator PcTurn(){
        GameObject[] activeCards = GameObject.FindGameObjectsWithTag("cards");
        List<GameObject> availableCards = new List<GameObject>();
        foreach (GameObject activeCard in activeCards)
        {
            if (!activeCard.GetComponent<Card>().isSelected){
                availableCards.Add(activeCard);
            }
        }
        cardSelectedByPc = availableCards[Random.Range(0, availableCards.Count)];
        playerTurn = false;
        pcTurn = false;
        yield return new WaitForSeconds(5);
        StartCoroutine(cardSelectedByPc.GetComponent<Card>().RotateCard()); 
    }
    
    void Comparation(){
        bool pcUp = cardSelectedByPc.GetComponent<Card>().isFaceUp;
        bool playerUp = cardSelectedByPlayer.GetComponent<Card>().isFaceUp;
        if(pcUp&&playerUp){
            int pcAttack = cardSelectedByPc.GetComponent<Card>().attack;
            int playerAttack = cardSelectedByPlayer.GetComponent<Card>().attack;
            if (playerAttack > pcAttack){
                playerScore ++;
                Debug.Log("Player " + playerScore + "  Pc "+ pcScore);
                //Add gem to player UI
                uiManager.Score(playerScore, "player");
                sfx.PlaySFX(sfx.playerPoint);
            }
            else if (playerAttack < pcAttack){
                pcScore++;
                Debug.Log("Player " + playerScore + "  Pc "+ pcScore);
                //Add gem to pc UI
                uiManager.Score(pcScore, "enemy");
                sfx.PlaySFX(sfx.pcPoint);
            }
            else{
                pcScore++;
                Debug.Log("Player " + playerScore + "  Pc "+ pcScore);
                // Tie UI
                uiManager.Score(pcScore, "enemy");
                sfx.PlaySFX(sfx.pcPoint);
            }
            Destroy(cardSelectedByPc);
            Destroy(cardSelectedByPlayer);
            playerTurn=true;
            pcTurn =false;
            turn++;
        }
    }
    
    #endregion

    void Result()
    {
        uiManager.WinLose(playerScore, pcScore);
        //Time.timeScale = 0;
    }
}
