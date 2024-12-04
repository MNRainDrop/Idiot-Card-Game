from Models.Card import Card
import random

def create_new_deck() -> list:
    """
    Creates a new standard 52 card deck.

    Returns:
        list: A standard 52 card deck that is sorted.
    """
    suits = ["♠", "♣", "♡", "♢"]
    values = ["A", "2", "3", "4", "5" ,"6", "7", "8", "9", "10", "J", "Q", "K"]

    return_list = []

    for suit in suits:
        for value in values:
            return_list.append(Card(suit, value))
    return return_list

def deal_card(deck:list) -> Card:
    """
    Returns a single card from the top of a given deck of cards. That same card is removed from the list of cards.

    Args:
        deck (list): List of cards that the card will be removed from.
    Returns:
        card: The top card of a deck.
    """
    if deck is not None:
        if len(deck) > 0:
            return deck.pop(0)
        else:
            raise ValueError("List cannot be empty")
    else:
        raise ValueError("List cannot be None")

def shuffle_deck(deck:list) -> None:
    """
    Randomizes the order of the cards in the deck.

    Args:
        deck (list): List of cards that the card will be shuffled
    """
    if deck is not None:
        if len(deck) > 0:
            for x in range(0, len(deck)-1):
                rand_card = random.randint(0,len(deck)-1)
                deck[x], deck[rand_card] = deck[rand_card], deck[x]
        else:
            raise ValueError("List cannot be empty")
    else:
        raise ValueError("List cannot be None")