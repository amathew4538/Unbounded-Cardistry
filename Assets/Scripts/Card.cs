using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "New Card")]
public class Card : ScriptableObject
{
    public GameObject cardBorder;
    public GameObject cardBkg;
    public GameObject cardElementDisplay;
    public GameObject cardImage;
    public string cardName;
    public int cardHealth;
    public int cardCost;
    public CardData.CardType cardType;
    public CardData.ElementType cardElement;
    public CardData.ElementType[] elementResists;
    public CardData.ElementType[] elementWeaknesses;
    public CardData.ElementType[] elementInfluences;

}
