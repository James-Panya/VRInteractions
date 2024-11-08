# VRInteractions

## Description
The three main interactions that I implemented were teleporting, being able to grab objects within VR, and pressing a virtual button. At first, I was going to implement three different teleportation variations, but when I started implementing them, two of them felt the exact same and didn't feel different at all. While the third one I couldn't for the life of me figure out how to implement.

## Interactions
### Teleporting
I already implemented teleporting, so I stuck with it as one of my interactions. A very simple, point at a location on the ground and teleport there.
### Picking Up Objects
This allows the player to interact with an object and grab it with the controller. As long as the ray hits the object, it'll come towards the player's hand.
### Button Interaction
I created not a UI Button, but a "physically" present button for the user to press down on. The button has a configurable joint which allows it to go up and down and collide with the trigger in order to activate the button.
### Haptic Feedback
This was added last minute, but I had very small haptic feedback whenever a player hovers over an interactable object. I didn't tell testers to see if they would notice, but it seems I didn't put enough vibrations for them to notice.

## Observations
All five of my testers seemed to be enjoying the interactions that I made. Users, ranged from no experience with games or VR to experience, all had very positive words and actions when interacting with my project. At the end, they said that they were very pleased and had little to no complaints about the interactions that I've made. The only complaint was that when holding down the teleport button, the teleport marker would go to the plane's origin for some reason. Aside from that, the interaction project seemed to be highly regarded.

## Questions
### Pre-questions
1. Have you had VR experience outside of the class before?
   - Overall, mostly no's.
2. Any experience with playing video games on a scale from 1 to 5. 1 being for none and 5 for very experienced.
   - An array of experience from all five testers
3. What kind of actions are you expecting to do in VR? For example, anything you're capable of doing in real life, so running, looking around, jumping, etc.
   - Most of the testers agreed with my examples and some added grabbing objects as an interaction and having feedback.
### Post-questions
1. Which interaction felt the most real or practical to you?
   - All five testers said that grabbing the object was the most intuative and felt the most real.
2. Any input controls that were confusing? For example the button layout on the controllers.
   - All testers besides one said that the button layout was completely fine. The one tester said that there should be a seperate button or more triggers to pick up the object.
3. Would you rather have more button inputs (through controller) or gesture inputs (in-game interactions)?
   - All five testers said that having gesture inputs would be more immersive than controller buttons. A few them said that controller buttons are okay from time to time though.
