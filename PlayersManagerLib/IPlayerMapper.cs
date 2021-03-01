using System;

namespace PlayersManagerLib
{
    public interface IPlayerMapper

    {
        bool IsPlayerNameExistsInDb(string name);

        void AddNewPlayerIntoDb(string name);

    }
}
