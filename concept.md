# Open world survival

* Multiplayer
* More story presence than is typical
    * Or, not so much story, but events/mysteries.
    * Some story, though.
* Virtually all construction is centered around player vehicles.
    * Solves the offline raiding conundrum. Vehicles leave the map shortly after the player does (or immediately if the player leaves manually).
* NPCs (for fun and profit)
    * Quests.
    * Relationships (faction system, ideally with real depth).
    * Trade.
    * Raid.
* Need to figure out how respawns should be handled.
    * Respawn at vehicle?
        * Would that prevent on-line raiding? (this would be bad)
        * Timer?
        * Require a vehicle upgrade?
    * Respawn at new player location with new player vehicle?
    * Either way, new player vehicle needs to be unfarmable.
    
    
# Potential Settings

## Future world

Players are stranded on an alien world. I imagine a sort of Chronicles of Riddick like universe where interstellar travel is somewhat common, but a little bit haphazard. The universe is big and dangerous and sometimes ships go missing or outposts stop transmitting. This is all background, of course; the whole game takes place on the ground.

Options:

* Potentially huge tech tree (hand tools -> future tech)
* In game communication can be a mechanic (radios)
* Events are easy (ship arrives)
* Fuel can become an interesting resource to manage (batteries, h2, synth hydrocarbons, petroleum, fissile materials, fussable materials; all good for different purposes/vehicles)

Challenges:

* Justifying a malleable map is a pretty big stretch
    * Lava planet is my best idea so far
* Adding variety to events could be difficult (yet another ship arrives)
* Justifying the player's innability to escape could be difficult
* Not sure how to explain respawning (clones, maybe?)
* Inventing alien ecologies is a lot of work

## Future space

Players find themselves in a relatively lawless backwater region of space. And they're broke. I imagine a huge sprawling space civilization, but space is even bigger (and more dangerous, too). For all except the most heavily trafficked worlds and routes, membership in the utopic space society is essentially voluntary, because space is just too big to force everyone to play nice. The "world map" is space; specifically orbits around things big enough to orbit in a part of space that isn't signing up with the utopia. Locations mostly consist of something that your ship could dock with, but planetary landings could also work.

Options:

* Lots of opportunity for zero-g, which could be cool
* No need to justify an innability to escape; other systems are just different flavors of backwater
* Events are easy (ship passing through, space weather makes other systems (un)available, space weather makes the system more difficult than normal)
* Radios
* Map is inherently malleable (space weather, mobile locations)

Challenges:

* Harder concept to present to players
* Constructing vehicles seems improbable, probably have to rely on sale/salvage (maybe not a problem)
* Space physics might be challenging
* Explain respawning (again, clones?)

## Post-apocalypse world

The world was destroyed (approximately). What's leftover had a shit time of things, then settled into a general cycle of horrible people doing horrible things and everyone else being too brutalized to put a stop to it for very long. Imagine Mad Max: Fury Road. Or maybe Waterworld.

Options:

* Events are a little challenging
* Radios, maybe
* No need to justify innability to escape; nowhere to escape to

Challenges:

* Explain respawning (psychotic breakdown? cursed to live?)
* Not treading on Mad Max IP could be difficult
* Making the map malleable is a little hard (only so many sand storms)

## Pirates

This is a magic fantasy world with golden age of sail technology. The world is full of small to large islands. And monsters. And ghosts. And pirates. And voodoo magic. And maybe other cool stuff. I assume you're now humming the theme to Pirates of the Caribean.

Options:

* Magic
* Fantasy Monsters
* Real easy concept
* Malleable map is easily justified (cuz islands and magic)
* Respawning is trivially explained (magic)

Challenges:

* Boats need to be pretty big to be useful (what about the crew?)
* No radios
* Shallow tech tree (maybe magic can add some depth)

# Mechanics

## Equipment

I'd like equipment and carrying to work more like the way worn/carried gear works IRL. Specifically, there are only a few body positions where equipment can be worn and rapidly accessible while still leaving hands free. These would be equip slots in gaming parlance. Specifically, I am imagining 3 or 4 small item holsters: 2 hips, 1 chest and/or 1 back. I can also envision 1 large object on a shoulder sling, and maybe 1 additional small object on a lanyard. Bulk items are carried in backpacks. Retrieving/readying items from an equip slot is very fast. Retrieving them from bulk storage like a backpack is comparatively slow (maybe as much as 10s, probably more like 4-5s). Managing bulk inventory shouldn't be needlessly tedious, though. The idea is to have a sort of realistically small limit on equipped items. There may be special cases for other equipment which can be used while worn and doesn't need to be held. For instance head lamps or shoulder microphones.

## Crafting/Construction

To clarify, in other OWS games like Ark, The Forest, Minecraft, Rust, etc building a permanent-ish base on the map which can be filled with resources is most of how you advance in the game. The core problem with this is that there is essentially no way to secure it while you are not logged in to the game (short of removing the ability to destroy them like is common in minecraft or PVE Ark servers). Returning to the game to discover that huge amounts of work have just been lost is disheartening. But making that kind of action impossible removes a big category of fun that many people are interested in. So instead, my idea is to eliminate the permanent fixed construction aspect and instead focus the building part of the game onto vehicles. Vehicles can logically (at least in video game logic) leave the map in the same way a player does when they log out. The result is that a player's resources are only ever at risk when they have a reasonable chance to defend them.
Aside from that, items and equipment would still be craftable in a way that should be familiar from other open world games. And I can envision temporary objects which could be built in the world (like tents and campfires).
I think crafting should be complex. Advanced crafting would rely on access to multiple types of work benches. For instance, an automobile will require at least a furnace, forge, casting molds, and a welder, plus heavy duty power tools. My hope with this is to strongly encourage a (at least part time) cooperative play style by requiring more crafting resources than a lone player can likely gather. This would especially be the case because each of these work stations would have to be installed on a vehicle and vehicle space will be at a premium.
By the same token, crafting materials should be varied and gathering/refining/synthesizing them should require specialized tools. Things like drills, kilns, stills, etc.
However, I don't want players to have to manage huge quantities of intermediate components. Instead I imagine a sort of project based system. For instance, the project could require X units of milled steel, Y units of cast aluminum, and Z uses of various power tools. The player would then feed steel into a milling machine, aluminum into a furnace/casting mold, then use the appropriate tools. Then voila, crafting complete. That way there's no need to bother with items like gears and hinges and so on that aren't interesting on their own. Large crafting projects could possibly be broken into stages.

## Survival

A big chunk of the gameplay in open world survival games is in gathering and managing the resources it takes to simply survive in a harsh and hostile world. At its simplest, that means things like hunger bars. I would prefer a more nuanced system.

### Food/Water/Oxygen

I want managing the charater's nutrition to remain an interesting component of the game beyond the first hour. I'm imagining a system where the recent history of nutrition will have effects on overall health. I'm not sure what the details of that look like, or even how detailed to make it. Do we worry about macro nutrients? Micros? Just calories? Either way, eating poorly or infrequently should impose some detriment. If this sends a player on a death spiral, so be it; it's a survival game. More often it should force the player to sometimes reprioritize food over other resources. The detriment could be reduced speed, endurance, carry weight, susceptibility to injury or illness, maybe other things. What this should not be is a hunger bar that drops to 0 and starts doing damage.
Oxygen provides another resource to manage in future settings. Not sure specifically how to do that, or if it would just be tedious and best to leave out.

### Fuel

The next most basic resource would be fuel. What this is depends mostly on the setting. In future world, it could take a lot of forms. In future space, it's mostly going to be hydrogen (for rockets and/or fusion). In apocalypse it could have some variety (ethanol and diesel/gasoline). In pirate world it would be magic (in the form or mana or something).
Fuel should be a gatherable resource, but I think it should also be free in small quantities or poor qualities. Since so much of the game will revolve around vehicles, having one get stranded without fuel seems like it would be just a slow and boring way to lose. So instead vehicles will not be strand-able. They should be slow and more or less defenseless without fuel, though. The justification would depend on the setting, but something like batteries recharge, more hydrogen gets scooped, some ethanol gets distilled, or mana regenerates.

### Materials

Gathering crafting materials will be one of the major time investments of established players (the others being player-player gameplay, player-npc gameplay, and exploration/investigation (that I can forsee)). I'd like to have a broad variety of materials to gather. Different types of food (cooking); construction materials like wood, metals, ceramics; fuel or fuel precursors like lithium for batteries or sugar sources for alchohols.

### Sleep

Not sure if I would want to have a sleep mechanic. Maybe.

### Injury and Healing

I think I'd like to have injury and medicine as mechanics. I think the survival aspect is enhanced if recovering from a fight takes a substantial amount of time (maybe as much as hours). As a starting point, health could recover naturally but slowly (maybe 1% per minute). Crafted food/meds/potions could speed that up. Maybe so could rest/sleep. Poor nutrition and heavy exertion could slow it down. Injuries might require medicine/potions to recover. Likewise poisons or diseases.

### Skills?

I'm completely undecided if it's valuable to have skills or stats or something inherent improvable about a character. I'm also unsure if I would want them to persist between deaths (making it easier for veteran players to recover after dying) or not persist (encouraging caution by imposing extra penalties for dying) or reset/re-choose (allowing more chance to experiment with different builds/play styles).

### Weather

Localized weather would be nice. Physics based weather effects would be really nice. Like accumulating snow, wind, rain water that pools and flows.

