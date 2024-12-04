import Managers.DeckManager as DeckManager
from Models.Player import Player

def setup_game():
    player_list = [Player("mnrd"), Player("Pat"), Player("Penis")]

    # Create Deck
    draw_deck = DeckManager.create_new_deck()
    # Shuffle Deck
    DeckManager.shuffle_deck(draw_deck)

    for player in player_list:
        if type(player) is not Player:
            raise TypeError("Expected Player")
        else:
            # Deal Face Down Life Cards
            for x in range(0,3):
                player.face_down_life.append(DeckManager.deal_card(draw_deck))
            # Deal Hand
            for x in range(0,6):
                player.hand.append(DeckManager.deal_card(draw_deck))