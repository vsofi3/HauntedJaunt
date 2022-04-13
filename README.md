# HauntedJaunt
CIS410 Assignment 2

Spring ’22 CIS 410/510 Assignment 2 – 100/100 points – Due Wednesday, 4/13, 11:59 PM

This is optionally a group assignment – it can be completed by a team of 1, 2, or 3 members.
Each submission will be expected to complete the tutorial and implement the items below, so
more team members equals less total work per person. Also, we’ll be working on a team
project (team size 3) for the remainder of the term, so I highly encourage you all to use this as
an opportunity to begin forming teams!

Please find a team by posting on Piazza or otherwise connecting with your classmates. Also
please email me before end of day on Wednesday, April 7th if you’d like help finding a team – I
will randomly group people together upon request.

1. [60] Do all of this:
https://learn.unity.com/project/john-lemon-s-haunted-jaunt-3d-beginner
One suggestion for splitting this up between 3 team members:
Build the basic project and environment together (Setting up 3D Beginner, The Environment).
Then split up the remaining tasks – something like:
• The Player Character Parts 1 and 2
• The Camera, Ending the Game, Audio
• Enemies Parts 1 and 2
These tasks will require coordination; we’ll be using Kanban boards later in the term, so you
might try using Trello to manage your milestones and dependencies for the project – available
here:
https://trello.com/en-US

2. [10] Add at least one gameplay element that uses a dot product in some way (e.g., calculate
length, distance, angle, facing direction).

3. [10] Add at least one gameplay element that uses linear interpolation in some way (e.g.,
calculate intermediate position, orientation, color).

4. [10] Add at least one particle effect.

5. [10] Create a repository (github, bitbucket, etc) for your project. In the repo readme,
describe the use of the dot product, linear interpolation, and particle effect and how to trigger
these in game. Also include the names of your team members and the contributions from each
team member.

New Features:
  - Dot Product: used to Vector3.Dot to position the Gargoyles GameObjects towards JohnLemon

  - Linear Interpolation: used to minimize the light intensity as the game plays out (I did this based on time/deltaTime)

  - Particle Effect: Added dark grey particle effects coming out of the Ghost GameObjects
