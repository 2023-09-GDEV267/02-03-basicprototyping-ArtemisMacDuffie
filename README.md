# Module1-Projects
 ApplePicker, Mission Demolition and Prototype 1

My prototype for this project involved automating the slingshot mechanics from Mission Demolition,
the scene management and trigger mechanics from ApplePicker, and extensive use of prefabs
as inspired by their implementation in both projects. The implementation of this design also
involved custom methods, static classes such as Time and Random, and many of the MonoBehavior
methods such as Update and OnTriggerEnter.

The player controls a slingshot that works much like that from Mission Demolition, but instead
of shooting a static target, the player is to collide their projectiles with hostile projectiles
from an automated launcher. Should the hostile projectiles land on a flowerbed, the flowerbed
turns into a weedbed. The scene resets if all five are turned into weedbeds.
