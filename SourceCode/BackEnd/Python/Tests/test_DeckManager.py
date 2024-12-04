import unittest
from Managers import DeckManager

class TestDeckManagerFunctions(unittest.TestCase):
    def test_create_new_deck(self):
        # Arrange & Act
        deck = DeckManager.create_new_deck()
        deck_as_a_set = set(deck)
        expected_number_of_cards = 52
        # Assert
        self.assertEqual(len(deck), expected_number_of_cards)
        self.assertEqual(len(deck_as_a_set), expected_number_of_cards)

    def test_deal_card_pass(self):
        # Arrange
        deck = DeckManager.create_new_deck()
        expected_cards_left_in_deck = len(deck) - 1
        top_card = deck[0]
        # Act
        card = DeckManager.deal_card(deck)
        # Assert
        self.assertEqual(len(deck), expected_cards_left_in_deck)
        self.assertEqual(top_card, card)
        self.assertNotEqual(card, deck[0])
        
    def test_deal_card_fail(self):
        # Arrange
        deck = []
        # Act & Assert
        with self.assertRaises(ValueError):
            DeckManager.deal_card(deck)

    def test_shuffle_deck_pass(self):
        # Arrange
        deck = [1,2,3,4,5,6,7,8,9,10]
        shuffled_deck = [1,2,3,4,5,6,7,8,9,10]
        # Act
        DeckManager.shuffle_deck(shuffled_deck)
        # Assert
        self.assertNotEqual(shuffled_deck, deck)
        self.assertEqual(len(shuffled_deck), len(deck))

    def test_shuffle_deck_fail(self):
        # Arrange
        deck = []
        # Act & Assert
        with self.assertRaises(ValueError):
            DeckManager.shuffle_deck(deck)