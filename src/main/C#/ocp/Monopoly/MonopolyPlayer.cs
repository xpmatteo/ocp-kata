using System;

namespace Ocp.Monopoly
{
    public class MonopolyPlayer
    {

        public int Balance { get; private set; }

        public MonopolyPlayer(string playerName)
        {
        }

        public void LandsOn(string squareName)
        {
        }

        public void SetBalance(int newBalance)
        {
            Balance = newBalance;
        }
        

        public Object location()
        {
            return null;
        }

        public void AddOwnedProperty(string squareName)
        {
        }

    }
}