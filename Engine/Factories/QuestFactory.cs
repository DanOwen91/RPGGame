using Engine.Interfaces.GameItems;
using Engine.Interfaces.QuestInterfaces;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    class QuestFactory
    {
        static QuestFactory()
        {
            //Singleton
            CreateQuests();
        }


        /// <summary>
        /// List of quests
        /// </summary>
        private static List<IQuest> quests = new List<IQuest>();

        private static void CreateQuests()
        {

            /// <summary>
            /// build some items
            /// </summary>
            ItemFactory itemFact = new ItemFactory();

            //Quest 1 reward items
            List<IGameItem> rewardItems = new List<IGameItem>()
            {
                itemFact.CreateGameItem(3),
                itemFact.CreateGameItem(5),
                itemFact.CreateGameItem(7)
            };

            //Quest 1 quest items
            List<IGameItem> questItems = new List<IGameItem>()
            {
                itemFact.CreateGameItem(12, 10),
            };

            quests.Add(new Quest(1, "Hunt for cats", "Hunt some cats and get there eyes", 100, 10, rewardItems, questItems));

            //Quest 2 reward items
            List<IGameItem> rewardItems2 = new List<IGameItem>()
            {
                itemFact.CreateGameItem(1)
            };

            //Quest 2 quest items
            List<IGameItem> questItems2 = new List<IGameItem>()
            {
                itemFact.CreateGameItem(9, 10),
            };

            quests.Add(new Quest(2, "Hunt for Rats", "Hunt some rats and get there skins", 100, 10, rewardItems2, questItems2));
        }

        /// <summary>
        /// Return a quest based on its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IQuest CreateQuest(int id)
        {
            
            return quests.FirstOrDefault(x => x.Id == id);
        }

    }
}
