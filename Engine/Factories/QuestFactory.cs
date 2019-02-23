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
            var factory = new QuestFactory();
            factory.CreateQuests();
        }
        /// <summary>
        /// List of quests
        /// </summary>
        List<IQuest> quests = new List<IQuest>();
        /// <summary>
        /// build some items
        /// </summary>
        ItemFactory itemFact = new ItemFactory();

        private void CreateQuests()
        {
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



        }


        public IQuest CreateQuest(int id)
        {
            return quests.FirstOrDefault(x => x.Id == id);
        }

    }
}
