Objects:
Table
Cards

Method: GenerateDecks(int in)
Input: int32 Expected Value:(1-4);
Output: A list of Card objects for the number of card decks * input value.
Description:
This function will add cards to our global Deck variable.
Example: Blackjack.GenerateDecks(2) => Will generate two decks.

Method: CardSum(Card in, int position);
Input: Card
Output: void
Description:
Takes a card and adds it to the current table position.

Method: TablePositionChecker(int Table[i])
Input: Position at a Table.
Output: Boolean
Description:
Determines whether a users card add up to 21 or above.

Method: HitMe(int TablePosition)
Input: Position at a table.
Output: void
Description:
