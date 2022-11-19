/*
 * The library makes it much easier to create games using playing cards. 
 * The library already has objects of all playing cards created on the basis 
 * of the Card class, and arrays of some types of decks of cards. 
 * 
 * Properties of playing cards:
 * 
 *      Suit: 4 types of suits
 *      Nominal value (name): all kinds of existing cards (14 playing cards)
 *      Color: Red or black 
 *      Price: Used in some games
 */

using System.Drawing;

namespace PlayingCards
{

    class Card
    {
        public enum Color {
            Black = 0,
            Red = 1
        };

        public enum Suit {
            spades = 0,
            cross = 1,
            hearts = 2,
            bubi = 3
        };

        public enum Name
        {
            Joker = 0,
            Ace = 1,
            _A = 1,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10,
            Jack = 11,
            _J = 11,
            Queen = 12,
            _Q = 12,
            King = 13,
            _K = 13
        }

        public enum Price {
            Ace = 11,
            _A = 11,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10,
            Jack = 2,
            _J = 2,
            Queen = 3,
            _Q = 3,
            King = 4,
            _K = 4
        };

        public Color color { get; }
        public Suit suit { get; }
        public Name name { get; }
        public int price { get; }
        public Image image;

        internal static Card[] DeckCards54 { get => deckCards54; }
        internal static Card[] DeckCards52 { get => deckCards52; }
        internal static Card[] DeckCards36 { get => deckCards36; }
        internal static Card[] DeckCards24 { get => deckCards24; }

        public Card(Color color, Suit suit, Name name, int price)
        {
            this.color = color;
            this.suit = suit;
            this.name = name;
            this.price = price;
        }

        public Card(Suit suit, Name name, int price)
        {
            this.suit = suit;
            this.name = name;
            this.price = price;

            if (suit == Suit.bubi || suit == Suit.hearts) this.color = Color.Red;
            if (suit == Suit.cross || suit == Suit.spades) this.color = Color.Black;
        }

        public Card(Name name, Color color)
        {
            this.color = color;
            this.name = name;
        }

        public Card(Suit suit, Name name)
        {
            this.suit = suit;
            this.name = name;
            if (name != Name.Joker)
            {
                switch (name)
                {
                    case Name._2: price = (int)Price._2; break;
                    case Name._3: price = (int)Price._3; break;
                    case Name._4: price = (int)Price._4; break;
                    case Name._5: price = (int)Price._5; break;
                    case Name._6: price = (int)Price._6; break;
                    case Name._7: price = (int)Price._7; break;
                    case Name._8: price = (int)Price._8; break;
                    case Name._9: price = (int)Price._9; break;
                    case Name._10: price = (int)Price._10; break;
                    case Name._J: price = (int)Price._J; break;
                    case Name._Q: price = (int)Price._Q; break;
                    case Name._K: price = (int)Price._K; break;
                    case Name._A: price = (int)Price._A; break;
                }
            }
            else price = 0;

            if (suit == Suit.bubi || suit == Suit.hearts) this.color = Color.Red;
            if (suit == Suit.cross || suit == Suit.spades) this.color = Color.Black;
        }

        public Card(Color color, Suit suit, Name name)
        {
            this.color = color;
            this.suit = suit;
            this.name = name;
            if (name != Name.Joker)
            {
                switch (name)
                {
                    case Name._2: price = (int)Price._2; break;
                    case Name._3: price = (int)Price._3; break;
                    case Name._4: price = (int)Price._4; break;
                    case Name._5: price = (int)Price._5; break;
                    case Name._6: price = (int)Price._6; break;
                    case Name._7: price = (int)Price._7; break;
                    case Name._8: price = (int)Price._8; break;
                    case Name._9: price = (int)Price._9; break;
                    case Name._10: price = (int)Price._10; break;
                    case Name._J: price = (int)Price._J; break;
                    case Name._Q: price = (int)Price._Q; break;
                    case Name._K: price = (int)Price._K; break;
                    case Name._A: price = (int)Price._A; break;
                }
            }
            else price = 0;

        }


        //      Cards
        public static Card RedJoker = new Card(Name.Joker, Color.Red);
        public static Card BlackJoker = new Card(Name.Joker, Color.Black);

        public static Card S_2 = new Card(Suit.spades, Name._2);
        public static Card C_2 = new Card(Suit.cross, Name._2);
        public static Card H_2 = new Card(Suit.hearts, Name._2);
        public static Card B_2 = new Card(Suit.bubi, Name._2);

        public static Card S_3 = new Card(Suit.spades, Name._3);
        public static Card C_3 = new Card(Suit.cross, Name._3);
        public static Card H_3 = new Card(Suit.hearts, Name._3);
        public static Card B_3 = new Card(Suit.bubi, Name._3);

        public static Card S_4 = new Card(Suit.spades, Name._4);
        public static Card C_4 = new Card(Suit.cross, Name._4);
        public static Card H_4 = new Card(Suit.hearts, Name._4);
        public static Card B_4 = new Card(Suit.bubi, Name._4);

        public static Card S_5 = new Card(Suit.spades, Name._5);
        public static Card C_5 = new Card(Suit.cross, Name._5);
        public static Card H_5 = new Card(Suit.hearts, Name._5);
        public static Card B_5 = new Card(Suit.bubi, Name._5);

        public static Card S_6 = new Card(Suit.spades, Name._6);
        public static Card C_6 = new Card(Suit.cross, Name._6);
        public static Card H_6 = new Card(Suit.hearts, Name._6);
        public static Card B_6 = new Card(Suit.bubi, Name._6);

        public static Card S_7 = new Card(Suit.spades, Name._7);
        public static Card C_7 = new Card(Suit.cross, Name._7);
        public static Card H_7 = new Card(Suit.hearts, Name._7);
        public static Card B_7 = new Card(Suit.bubi, Name._7);

        public static Card S_8 = new Card(Suit.spades, Name._8);
        public static Card C_8 = new Card(Suit.cross, Name._8);
        public static Card H_8 = new Card(Suit.hearts, Name._8);
        public static Card B_8 = new Card(Suit.bubi, Name._8);

        public static Card S_9 = new Card(Suit.spades, Name._9);
        public static Card C_9 = new Card(Suit.cross, Name._9);
        public static Card H_9 = new Card(Suit.hearts, Name._9);
        public static Card B_9 = new Card(Suit.bubi, Name._9);

        public static Card S_10 = new Card(Suit.spades, Name._10);
        public static Card C_10 = new Card(Suit.cross, Name._10);
        public static Card H_10 = new Card(Suit.hearts, Name._10);
        public static Card B_10 = new Card(Suit.bubi, Name._10);

        public static Card S_Jack = new Card(Suit.spades, Name._J);
        public static Card C_Jack = new Card(Suit.cross, Name._J);
        public static Card H_Jack = new Card(Suit.hearts, Name._J);
        public static Card B_Jack = new Card(Suit.bubi, Name._J);

        public static Card S_Queen = new Card(Suit.spades, Name._Q);
        public static Card C_Queen = new Card(Suit.cross, Name._Q);
        public static Card H_Queen = new Card(Suit.hearts, Name._Q);
        public static Card B_Queen = new Card(Suit.bubi, Name._Q);

        public static Card S_King = new Card(Suit.spades, Name._K);
        public static Card C_King = new Card(Suit.cross, Name._K);
        public static Card H_King = new Card(Suit.hearts, Name._K);
        public static Card B_King = new Card(Suit.bubi, Name._K);

        public static Card S_Ace = new Card(Suit.spades, Name._A);
        public static Card C_Ace = new Card(Suit.cross, Name._A);
        public static Card H_Ace = new Card(Suit.hearts, Name._A);
        public static Card B_Ace = new Card(Suit.bubi, Name._A);

        private static Card[] deckCards54 = {
            RedJoker,
            BlackJoker,

            S_2,
            S_3,
            S_4,
            S_5,
            S_6,
            S_7,
            S_8,
            S_9,
            S_10,
            S_Jack,
            S_Queen,
            S_King,
            S_Ace,
            C_2,
            C_3,
            C_4,
            C_5,
            C_6,
            C_7,
            C_8,
            C_9,
            C_10,
            C_Jack,
            C_Queen,
            C_King,
            C_Ace,
            H_2,
            H_3,
            H_4,
            H_5,
            H_6,
            H_7,
            H_8,
            H_9,
            H_10,
            H_Jack,
            H_Queen,
            H_King,
            H_Ace,
            B_2,
            B_3,
            B_4,
            B_5,
            B_6,
            B_7,
            B_8,
            B_9,
            B_10,
            B_Jack,
            B_Queen,
            B_King,
            B_Ace
        };
        private static Card[] deckCards52 = {
            S_2,
            S_3,
            S_4,
            S_5,
            S_6,
            S_7,
            S_8,
            S_9,
            S_10,
            S_Jack,
            S_Queen,
            S_King,
            S_Ace,
            C_2,
            C_3,
            C_4,
            C_5,
            C_6,
            C_7,
            C_8,
            C_9,
            C_10,
            C_Jack,
            C_Queen,
            C_King,
            C_Ace,
            H_2,
            H_3,
            H_4,
            H_5,
            H_6,
            H_7,
            H_8,
            H_9,
            H_10,
            H_Jack,
            H_Queen,
            H_King,
            H_Ace,
            B_2,
            B_3,
            B_4,
            B_5,
            B_6,
            B_7,
            B_8,
            B_9,
            B_10,
            B_Jack,
            B_Queen,
            B_King,
            B_Ace
        };
        private static Card[] deckCards36 = {
            S_6,
            S_7,
            S_8,
            S_9,
            S_10,
            S_Jack,
            S_Queen,
            S_King,
            S_Ace,
            C_6,
            C_7,
            C_8,
            C_9,
            C_10,
            C_Jack,
            C_Queen,
            C_King,
            C_Ace,
            H_6,
            H_7,
            H_8,
            H_9,
            H_10,
            H_Jack,
            H_Queen,
            H_King,
            H_Ace,
            B_6,
            B_7,
            B_8,
            B_9,
            B_10,
            B_Jack,
            B_Queen,
            B_King,
            B_Ace
        };
        private static Card[] deckCards24 = {
            S_9,
            S_10,
            S_Jack,
            S_Queen,
            S_King,
            S_Ace,
            C_9,
            C_10,
            C_Jack,
            C_Queen,
            C_King,
            C_Ace,
            H_9,
            H_10,
            H_Jack,
            H_Queen,
            H_King,
            H_Ace,
            B_9,
            B_10,
            B_Jack,
            B_Queen,
            B_King,
            B_Ace
        };


    }
}
