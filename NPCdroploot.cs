using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.NPCs
{
    class NPCdroploot : GlobalNPC
{
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == NPCID.EyeofCthulhu) //1
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Retina"), 2);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Lens, 1);
		}

		// Addtional if statements here if you would like to add drops to other vanilla npc.

        if(npc.type == NPCID.GiantTortoise)//2
		if (Main.rand.Next(10) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.TurtleShell, 1);
		}

		if(npc.type == NPCID.Nurse)//3
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, 1);
		}

		if(npc.type == NPCID.SkeletronHead)//4
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"), 3);
		}

		if(npc.type == NPCID.Plantera)//5
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeFruitSeed"), 3);
		}
		
		//angry bones, ph dun enemys
		if(npc.type == NPCID.AngryBones)//6
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.AngryBonesBigMuscle)//7
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.AngryBonesBig)//8
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.AngryBonesBigHelmet)//9
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.ShortBones)//10
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.BigBoned)//11
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.DarkCaster)//12
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.DungeonSlime)//13
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldenKey);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldenKey);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldCoin);
		}

		if(npc.type == NPCID.QueenBee)//14
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Boomstick);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.IllegalGunParts);
		}

		if(npc.type == NPCID.BlueJellyfish)//8
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeJar"));
		}

		if(npc.type == NPCID.PinkJellyfish)//8
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeJar"));
		}

		if(npc.type == NPCID.GreenJellyfish)//8
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeJar"));
		}
	}
}
}
