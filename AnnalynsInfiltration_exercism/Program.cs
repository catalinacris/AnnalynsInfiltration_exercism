using System;

namespace AnnalynsInfiltration_exercism
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestLogic.CanFastAttack(true);
            QuestLogic.CanSpy(false, true, false);
            QuestLogic.CanSignalPrisoner(false, true);
            QuestLogic.CanFreePrisoner(false, true, false, false);
        }

    }
}
