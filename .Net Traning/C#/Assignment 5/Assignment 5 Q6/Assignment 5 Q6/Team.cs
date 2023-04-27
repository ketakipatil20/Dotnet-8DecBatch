using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Assignment_5_Q6
{
    class Team:IEnumerable
    {
        private Player[] players;
        public Team(Player[] pArray)
        {
            players = new Player[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                players[i] = pArray[i];

            }
        }
        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TeamEnum GetEnumerator()
        {
            return new TeamEnum(players);
        }
        //  implement IEnumerator.
        public class TeamEnum : IEnumerator
        {
            public Player[] players;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;


            public TeamEnum(Player[] li)
            {
                players = li;
            }
            public bool MoveNext()
            {
                position++;
                return (position < players.Length);
            }
            public void Reset()
            {
                position = -1;
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            public Player Current
            {
                get
                {
                    try
                    {
                        return players[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

    }
}
