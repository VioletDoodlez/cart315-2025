You wake up in a field of soft, plush grass, trying to remember how you got here in the first place.
-> begin

=== begin ===
You feel a bit dizzy.
 + [Get up and look around.] -> look 
 + [I need a minute.] -> minute
 
 === minute ===
 Ok, well, hurry up then.
 + [Get up and look around.] -> look
 
 === look ===
 You inspect your surroundings. The field seems to stretch out for miles. The only thing that catches your eye is the forest behind you, long trees that twist and contort in strange ways. Trees don't grow like that where you live...
 
 That's when your memories of the night before come back to you. A flash of light, and a large, clawed hand reaching for your best friend. You ran after them. Did that light bring you hear?
 
 You have to find them. The forest seems like the best place to start. The forest, conviniently, has a pathway.
 
 * [Take the pathway.] -> pathway
 * [Try and cut through the forest.] -> forest
 
  === forest ===
 What harm could come from a little exploring? You cut through the forest.
 
 You walk for a while, until you find a clearing.
 + [Keep walking.] -> walk
 + [Rest for a while.] -> rest
 
 === pathway ===
 You're not risking potential danger. You walk along the path.
 
 Lucky for you, the path stays straight, not twisting or turning in any way. The trip feels...boring.
 
 After hours of walking nonstop, your legs feel like jelly. The sun is starting to set, you need to find a place to sleep soon.
 
 + [Keep walking.] -> walk
 + [Set up camp.] -> camp
 
 === camp ===
Better settle down for the night and build a fire.

While you search for firewood, you come across a tall, wide tree. Weirdly enough, this tree has windows, a tiny metal chimney sticking out from the side, and a door just big enough for you to enter.

There’s a light on behind those windows. Someone’s home.

*[Knock.] -> knock
*[Ignore.] -> ignore

=== ignore ===
Best not bother them.

You collect as many twigs and dry leaves as you can and make a small fire. As you watch the flames dance, you can’t help but feel homesick and the reality of your situation dawns on you:

You have no clue where to find your best friend.

You worry about their wellbeing. They’re probably scared to death in a sewer somewhere. If this place even has sewers.

You fall asleep to the gentle crackling of the fire, determined to bring them home.

-> END.

=== knock ===
It wouldn’t hurt to try. You knock three times. -> entertwig



=== walk ===
You decide to keep going.

{pathway: 
Despite the ache, you carry on. After a mere three steps, your knees buckle and you fall to the ground. Maybe resting for a few minutes on the road will do you some good. You pass out. -> wake
}

{forest:
The sun starts to set after a while, it’s getting darker. You start to realize that you don’t recognize your surroundings. You’re no longer near the path. You’re completely lost.

*[Cry.] -> cry
*[Try to retrace your steps.] -> retrace
}

=== retrace ===
You turn around, trying to remember where you came from. You go in circles trying to find where to go. You stumble around in the dark for hours, your arms and legs scratched from all the briar bushes you’ve stumbled into in the dark. You pass the same rock more that a dozen times. The sun never rises.

You never escaped that forest.

-> END

=== cry ===
Your vision starts to blur. It’s completely dark around you and your situation feels hopeless. You can’t help but let your tears out. It starts off as a sniffle before becoming full blown crocodile tears. You could tone it down a bit you know…

You hear a snap.

A bush rustles near you.

*[Freeze.] -> freeze 
*[Arm yourself.] -> arm

=== freeze ===
Maybe if you stay still it’ll go away?

…

The rustling gets louder. -> meettwig

=== arm ===
You pick up a large rock from the ground, getting into a defensive stance. -> meettwig

=== meettwig ===
Standing your ground, you see a tiny creature pop out of the bush.

It can’t be more than 5 apples tall. It’s dressed in a pair of pants with a matching brown vest and hat. It has big eyes, green skin, and a pointy nose and ears.

It looks kinda cute.

{ arm: 
“WOAH!!! Don’t hurt me!!!”
You lower the rock and set it on the ground. It sighs in relief.
}

“I’m sorry if I scared you, I just saw you crying and wondered if you were hurt.”

*[“Who are you?”] -> who
*[“I’m fine, thank you.”] -> fine

=== who ===
“Oh! Where are my manners? I’m Twig! It’s nice to meet you!” -> invite

=== fine ===
“Phew, that’s a relief! Not the strangest thing I’ve seen today, though.”

It sure is for you… -> invite

=== invite ===
“You probably don’t have a place to sleep, do you?”

You don’t exactly have any survival skills. 

{meettwig:
“You should stay at my house! I have a spare room!”
}

{entertwig: 
“Come on in! I’ve got plenty of room!”
You definitely need to to know what he meant by “human”. Besides…
}


You could use a bed. -> kitchen

=== rest ===
A break sounds like a good idea. You sit on the grass and rest your back on a tree trunk. The sound of trees rustling in the wind lulls you to sleep. -> wake

=== wake ===
You wake up in a dimly lit room, with wooden walls. You’re lying in a bed half your size, your legs falling off the edge. Are you inside of a tree?

The door handle turns slowly.

*[Hide.] -> hide
*[Defend.] -> defend

=== hide ===
The furniture in the room is way too small, you’ll be seen immediately. Except for…

You hide under your blanket. -> entertwig

=== defend ===
You stand up, getting in a fighting stance. -> entertwig

=== entertwig ===
The door opens, but you don’t see anyone…

“Down here!”

Oh?

You look down.

You see a tiny creature.

It can’t be more than 5 apples tall. It’s dressed in a pair of pants with a matching brown vest and hat. It has big eyes, green skin, and a pointy nose and ears.

It looks kinda cute.

{wake: 
“I know you must be confused and I’m sooo sorry. My name’s Twig, and um, I saw you asleep in the forest. I don’t know how long you’ve been asleep, but it was dark out so I though it would be a good idea to bring you here to my house.”

Wow, you slept for awhile…

“Um, I made you some tea. Feel free to join me in the kitchen!” -> kitchen
}

{knock:
“Hellooo there! I’m Twig!”

Wow, he waisted no time.

“Oh, how exciting! Two humans in one day! You don’t see many humans wandering in this forest.”

Wait, what? Did he say human? -> invite
}

=== kitchen ===
...

...

Sitting at Twig’s (tiny) table, you sip tea from a (tiny) teacup as he tells you about his day. He says he saw a human on the shoulder of The Demon King, as he passed through the forest to get to his realm. The human’s description matches your best friend’s exactly.

Great.

Perfect.

Of all people to be taken by in a fantasy world, your best friend gets taken by The Demon King…

As much as you’d like pass on the dangerous quest, you’re left with little choice but to go and save your best friend.

As Twig goes on, you soon realize you’ll have to save them from a fate worse than death.

You’ll have to save them from…

Marriage.

TO BE CONTINUED...

-> END.

 


