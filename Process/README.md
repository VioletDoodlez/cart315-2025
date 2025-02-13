# Process Journal

## Thursday, January 23, 2025: Make a Thing

I was really stumped when trying to figure out what kind of game I wanted to make. Before I realized we had to use the engines given to us, I thought of making a “wack-a-mole” type game using javascript p5.

When looking through the different game making tools, I settled on Ink for a few reasons:

1.	I checked the basic tutorial before downloading it and the “coding” was quick and easy to understand.
2.	I enjoy writing stories, so this would be a fun exercise to test how I’d do with writing one.

Obviously, I couldn’t write an entire story, and I had to have enough to explore the main mechanics.

I decided to use the concept I had for a story where a demon king takes a human girl as a bride in order to gain control of the surface world through this union and it’s up to the girl’s best friend to save her.

I started writing with the intent of only writing a “first chapter” as a sort of way of starting a story and leaving it open ended.

I wrote up until the “pathway vs forest” choice and decided it would be easier if I make a map of all possible choices and have them meet up in certain places.

I ended up removing one of the option selections in the final product, mainly to save time for the project. I made it so that most choices get you to the same ending but still added some alternative endings to add some variety.

I wrote the rest of my text in a Google Document because it would be easy to write in my spare time. I pasted it into my file and fixed some of the coding mistakes I’ve made.

I made sure to add conditions, so that depending on the choices the player makes, the dialogue might change.

I kept my writing simple and to the point in most cases, while still adding a small twist of humor to it and making the narrator a bit sassy. If I had more time to explore this tool, I would have definitely loved to see what other choices I could give to the player. 

[Project for class](../Projects/make-a-thing)

## Thursday, January 30, 2025: Starting Unity

I had a bit of trouble when it came to recreating the exercise we did in class and adding my own twist onto it. I decided to do something simple, where the player would have to avoid the falling circles.

Because I had troubles with the school computers while trying to work in Unity, I had to start from scratch. I remembered most of the process from memory, but I had to ask for help quite a few times simply to get the base code working. I have used Unity one or twice beforehand, but never to the point where I would complete a project, much less understand when I was writing. Having worked with javascript p5 last school year, I was able to make vague connection with what I learned at the time with what I was learning now. Still, it may take me some time before I figure it out completely.

What did help me greatly were some tutorials on how to add a lives system. While it was a bit challenging for me, I was able to understand the code a little bit better. The coding wasn’t exactly what I was looking for, but I’m proud of the fact that I ended up figuring out how to have it fit with the type of game I wanted to make.

Something I’m pretty proud of was figuring out how to make the player (square) disappear. I was already given an “if” statement when the lives counter reached 0, so I had to figure out how to use Destroy(), using the coding we learned in class to do so.

Overall, even if there isn’t much to my project, I think I still found a way to make it interesting and give it a goal.

[Project for class](../Projects/testUnity/)

## Thursday, February 6, 2025: Pong (or rather, Pawng)

After we created our template it class, I already knew what I wanted to try making. I wanted to make Pong, but with four paddles instead of just two, with one paddle on each side.

In terms of my understanding of C#, I think it’s gotten better and I’m getting used to working both in VS Code and Unity at the same time (downloading a C# and Unity extension did help a lot). I didn’t ask for help this time, as I ended up solving any issues I had on my own. For example, when my top and bottom paddles were starting off at the center of the scene unlike my left and right ones, I figured out that I needed to write a different transform.localPosition for them, because they use xPos, not yPos. It seems simple in hindsight, but I’m still figuring it out.

I wanted the gameplay to be hard but still fair. Because there was a paddle on each side, the ball could not touch any of the walls. To make the stakes even higher, if the left paddle moved in one direction, the right one would be inverted (up becomes down and vice versa). Because both are connected to the same keys, you’d have to focus and remember the inversion. The same thing happens with the top and bottom paddles, but on the X axis; the top one moves left, the bottom one moves right. Originally, I had all of them move with the up and down keys, but after testing this myself, I realized that it would be too difficult to catch the ball on the paddles. So, I linked the top and bottom paddles to the A and D keys. That way, the player can use both hands to play. The blip’s pitch changes when the ball hits either the top or bottom paddle.

I thought of adding the scores, using the method I used last time for my life counter didn’t seem to be working and caused a few issues I had to fix. I hope to figure out how to add scores for each side. In the end, because each opposite side had the same controls, I made it so that Player 1 was the left and right and Player 2 was the top and bottom, which would make keeping track of all scores a little easier.

[Project for this week](../Projects/pawngFour/)

## Thursday, February 13, 2025: Breakin' Out

Due to being very busy with projects this week, I haven’t had a chance to explore a lot in Unity. I wanted to try and make the brick layer move on its own at random intervals, but I only really managed to make the layer move within a single area, kind of like it was shaking. While it wasn’t what I was trying to achieve, it actually really liked how it looked, it could make for a very interesting visual effect.

If I had more time to keep experimenting, I would try to explore how to make automated movements. I may have to use a for loop to keep it in constant motion, or rather a while loop, after you hit the spacebar to make the ball start moving. I’d like to find out how to make the movements a bit longer (and slower) too, because while the shaking is an interesting effect, I’d like for the bricks to move in a way that doesn’t make the player dizzy. Kind of like Space Invaders, but instead of the bricks moving down, left, down, right constantly, it stays in upper two thirds of the scene, moving in either direction at random, slow enough not to disorient the player too much. I’d have to put a limit to the xPos and yPos of the brick layer, so that it both doesn’t reach beyond the lower third of the screen and doesn’t fly off screen when playing.

I’d also have to set a constant speed, but an interesting idea would be to make it move a little faster with every brick you break, just as a fun challenge.

[Attempt for this week](../Projects/breakinOut/)


