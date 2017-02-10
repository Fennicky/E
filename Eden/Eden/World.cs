using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_RUSTED_JAIL_KEY = 10;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        public const int NPC_ID_CHURCHGUY = 1;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_JOIN_THE_CHURCH = 3;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_DARK_FOREST = 10;
        public const int LOCATION_ID_ROLLING_HILLS = 11;
        public const int LOCATION_ID_MOUNTAIN = 12;
        public const int LOCATION_ID_DRAKE_CAVE = 13;
        public const int LOCATION_ID_TOWN_INN = 14;
        public const int LOCATION_ID_TOWN_CHURCH = 15;


        public const int UNSELLABLE_ITEM_PRICE = -1;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

            private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 2, 5, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 1));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 1));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 1));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 1));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10, 10));
            Items.Add(new CombatItem(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 3));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 1));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 1));
            Items.Add(new Item(ITEM_ID_RUSTED_JAIL_KEY, "Rusted Jail Key", "Jail Key", UNSELLABLE_ITEM_PRICE));
        }


        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.lootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.lootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.lootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.lootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.lootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, false));
            giantSpider.lootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 75, true));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            //AlchemistGarden Quests
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear the alchemist's garden", "kill rats in the alchemist's garden and bring back 3 rat tails. Reward: Healing potions and 10 gold.", 20, 10);

            clearAlchemistGarden.questCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.rewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            //FarmerFieldQuests
            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD, "Clear the farmer's field", "kill snakes in the farmer's field and bring back 3 snake fangs. Reward: Rusted Jail Key and 20 gold.", 20, 20);

            clearFarmersField.questCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearFarmersField.rewardItem = ItemByID(ITEM_ID_RUSTED_JAIL_KEY);

            //ChurchQuests
            Quest joinTheChurch = new Quest(QUEST_ID_JOIN_THE_CHURCH, "Join the church. Whatever that means.", "Talk to High Priest Sam when you have gathered 500 gold coins to cover the membership fee.", 1, 0);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateNPCs()
        {
            NPC churchGuy = new NPC(NPC_ID_CHURCHGUY, "High Priest Sam", 50, 100, 25, 100, 100, QuestByID(QUEST_ID_JOIN_THE_CHURCH));
            churchGuy.lootTable.Add(new LootItem(ItemByID(ITEM_ID_CLUB), 100, true));
            churchGuy.lootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 75, false));
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house.");

            Location hospital = new Location(LOCATION_ID_TOWN_CHURCH, "Church", "A small village church.");
            hospital.NPCsLivingHere.Add(NPCByID(NPC_ID_CHURCHGUY));


            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square.", "A small clock tower and fountain are here.");
            Vendor ZipTheRatCatcher = new Vendor("Rat-catcher Zipper Rumpus");

            ZipTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);
            ZipTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_RAT_TAIL),3);

            townSquare.vendorWorkingHere = ZipTheRatCatcher;


            Location alchemisthut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemisthut.questAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's Garden", "Many plants are growing here");
            alchemistsGarden.monstersLivingHere.Add(MonsterByID(MONSTER_ID_RAT));
            alchemistsGarden.monstersLivingHere.Add(MonsterByID(MONSTER_ID_SNAKE));

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer working out front.");
            farmhouse.questAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Eden.Location(LOCATION_ID_FARM_FIELD, "Farmer's Field", "there are lots of vegtables growing here.");
            farmersField.monsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough looking guard here.", ItemByID(ITEM_ID_RUSTED_JAIL_KEY));
            

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crossing a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest","You see spider webs covering the trees in this forest.");
            spiderField.monsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            //Home links
            home.locationToNorth = townSquare;


            //Town Square Links
            townSquare.locationToNorth = alchemisthut;
            townSquare.locationToSouth = home;
            townSquare.locationToEast = guardPost;
            townSquare.locationToWest = farmhouse;

            //Farm house links
            farmhouse.locationToEast = townSquare;
            farmhouse.locationToWest = farmersField;

            //farm field links
            farmersField.locationToEast = farmhouse;


            //Alchemist hut links
            alchemisthut.locationToSouth = townSquare;
            alchemisthut.locationToNorth = alchemistsGarden;

            //Alchemist's Garden Links
            alchemistsGarden.locationToSouth = alchemisthut;

            //Guard post links
            guardPost.locationToEast = bridge;
            guardPost.locationToWest = townSquare;

            //Stone Bridge links
            bridge.locationToWest = guardPost;
            bridge.locationToEast = spiderField;

            //SpiderField links
            spiderField.locationToWest = bridge;



            //Add all locations to list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistsGarden);
            Locations.Add(alchemisthut);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static NPC NPCByID(int id)
        {
            foreach(NPC npc in NPCs)
            {
                if(npc.ID == id)
                {
                    return npc;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }

    }
}
